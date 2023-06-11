using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using LanguageEditor.Models;

namespace LanguageEditor.RepositoryClasses
{
    internal static class FileExtractor
    {
        private static readonly string _mainDirPath = $@"C:\Users\{Environment.UserName}\Documents\LanguageEditor\";
        private static readonly string _repoPath = _mainDirPath + @"projects\";
        private static readonly string _configPath = _mainDirPath + @"config.txt";


        public static string GetMainDirPath()
        {
            return _mainDirPath;
        }
        public static bool EnsureDataDirExists()
        {
            return Directory.Exists(_mainDirPath);
        }
        public static List<ModelFile> GetModelFiles()
        {
            List<ModelFile> metamodels = new List<ModelFile>();

            try
            {
                string[] dirs = Directory.GetDirectories(_repoPath);

                foreach(string dir in dirs)
                {
                    string metamodelFile = Directory.GetFiles(dir, "*.xml", SearchOption.TopDirectoryOnly)[0];
                    string[] models = Directory.GetFiles(dir + "\\models", "*.xml", SearchOption.TopDirectoryOnly);
                    ModelFile metamodel = new ModelFile(metamodelFile);               

                    foreach(string model in models)
                    {
                        metamodel.Models.Add(new ModelFile(model));
                    }

                    metamodels.Add(metamodel);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return metamodels;
        }
        public static List<long> GetObjectIdCounters()
        {
            var ids = new List<long>();
            
            try
            {
                var lines = File.ReadAllLines(_configPath);
                ids.AddRange(lines.Select(line => line.Split('=')).Select(splitted => Int64.Parse(splitted[1])));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка при чтении config.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ids;
        }
        public static void WriteObjectIdCounters(string[] lines)
        {
            try
            {
                File.WriteAllLines(_configPath, lines);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка при сохранении config.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CreateProject(DiagramModel metamodel, IPackager packager)
        {
            try
            {
                var projDir = $@"{_repoPath}{metamodel.Name}\";
                metamodel.Data.FilePath = projDir + $"{metamodel.Name}.xml";

                Directory.CreateDirectory(projDir);
                Directory.CreateDirectory(projDir + "models");
                var fs = File.Create(metamodel.Data.FilePath);
                fs.Close();
                packager.Pack(metamodel, metamodel.Data.FilePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void DeleteProject(ModelFile metamodel)
        {
            try
            {
                var s = metamodel.Name.Split('.');
                Directory.Delete(_repoPath + s[0], true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
