using PipelineTextTransformer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PipelineTextTransformer.DataAccess
{
    public class DAL
    {
        public SaveFileDialog saveFileDialog1;
        OpenFileDialog openFileDialog;
        public DAL()
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory =  getWorkingDirectory();

            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = getWorkingDirectory();
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"; // xml files (*.xml)|*.xml|All files (*.*)|*.*       txt files (*.txt)|*.txt|All files (*.*)|*.*
            //openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
        }
        public void TestDeserialization(ProjectContainer project)
        {
            //Newtonsoft.Json.JsonSerializer k = Newtonsoft.Json.JsonSerializer.CreateDefault();
            
            //JsonSerializerOptions opt = new JsonSerializerOptions();
            
            //string data = JsonSerializer.Serialize<ProjectContainer>(project);

            //ProjectContainer pr = JsonSerializer.Deserialize<ProjectContainer>(data);
            //SetPipelineObjectTypes(pr.mainTransformer_2);
        }

        public ProjectContainer Deserializeproject(string str)
        {
            ProjectContainer pr = JsonSerializer.Deserialize<ProjectContainer>(str);
            SetPipelineObjectTypes(pr.mainTransformer_2);
            return pr;
        }
        public string Serializeproject(ProjectContainer proj)
        {
            return JsonSerializer.Serialize<ProjectContainer>(proj);
        }
        private void SetPipelineObjectTypes(PipelineTransformer tr)
        {
            Assembly asm = typeof(Transformer).Assembly;

            for (int i = 0; i < tr.Children.Count; i++)
            {
                JsonElement vehicle_Json = (JsonElement)tr.Children[i];
                string rawJson = vehicle_Json.GetRawText();
                string typestring = vehicle_Json.GetProperty("objType").ToString();
                Type curType = asm.GetType(typestring);

                Transformer processedTransformer = (Transformer)JsonSerializer.Deserialize(rawJson, curType);

                tr.Children[i] = processedTransformer;

                if (processedTransformer is PipelineTransformer)
                {
                    SetPipelineObjectTypes((PipelineTransformer)processedTransformer); // Recursive method. Processes all the nested Pipelines.
                }
            }
        }
        public void SaveAndOverwriteProject(ProjectContainer project,bool askForPath)
        {
            string mypath = project.projectPath;
            if (mypath == null || askForPath)
            {
                // Prompth the user


                saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    mypath = saveFileDialog1.FileName;
                    string data_ = Serializeproject(project);
                    File.WriteAllText(mypath, data_);
                }
            }
            else
            {
                string data_ = Serializeproject(project);
                File.WriteAllText(mypath, data_);
            }
            project.projectPath = mypath;
        }

        public string getWorkingDirectory()
        {
            //return Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return Environment.CurrentDirectory;
            //return   Directory.GetParent(workingDirectory).Parent.FullName;
        }

        internal ProjectContainer OpenFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }

            ProjectContainer imp = Deserializeproject(fileContent);
            imp.projectPath = filePath;

            return imp;
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            //return new ProjectContainer();
        }

        internal string GetFileText(out string filePath)
        {
            var fileContent = string.Empty;
            filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return fileContent;
        }
    }
}
