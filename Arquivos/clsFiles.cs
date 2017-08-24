using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Arquivos
{
    class clsFiles
    {

        public StreamReader DevolverStreamReader(string strFile)
        {
            try
            {
                var stReader = new StreamReader(@strFile, Encoding.GetEncoding(0));
                return stReader;
            }
            catch
            {
                throw;
            }
        }

        public List<string> DevolverArquivosDiretorio(string strCaminho)
        {
            List<string> lstArquivos = new List<string>();

            try
            {
                DirectoryInfo Dir = new DirectoryInfo(strCaminho);
                FileInfo[] files = Dir.GetFiles("*", SearchOption.AllDirectories);
                foreach (FileInfo File in files)
                {
                    lstArquivos.Add(File.FullName);
                }

                return lstArquivos;
            }
            catch
            {
                throw;
            }
        }

        public int ContarLinhasTexto(string strArquivo)
        {
            string strMsg;
            int intCont = 0;
            var stReader = DevolverStreamReader(strArquivo);
            
            try
            {
                while ((strMsg = stReader.ReadLine()) != null)
                {
                    intCont++;
                }

                return intCont;
            }
            catch
            {
                throw;
            }

        }
    }
}
