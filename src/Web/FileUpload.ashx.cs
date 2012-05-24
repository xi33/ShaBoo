namespace ShaBoo.Web
{
    using System;
    using System.Web;
    using System.IO;

    /// <summary>
    /// File Upload httphandler to receive files and save them to the server.
    /// </summary>
    public class FileUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            const string path = "App_Data";
            String filename = HttpContext.Current.Request.Headers["X-File-Name"];

            if (string.IsNullOrEmpty(filename) && HttpContext.Current.Request.Files.Count <= 0)
            {
                context.Response.Write("{success:false}");
            }
            else
            {
                string mapPath = HttpContext.Current.Server.MapPath(path);
                if (Directory.Exists(mapPath) == false)
                {
                    Directory.CreateDirectory(mapPath);
                }
                if (filename == null)
                {
                    //This work for IE
                    try
                    {
                        HttpPostedFile uploadedfile = context.Request.Files[0];
                        filename = uploadedfile.FileName;

                        uploadedfile.SaveAs(mapPath + "\\" + filename);

                        context.Response.Write("{success:true, name:\"" + filename + "\", path:\"" + path + "/" + filename + "\"}");

                    }
                    catch (Exception)
                    {
                        context.Response.Write("{success:false}");

                    }
                }
                else
                {
                    //This work for Firefox and Chrome.
                    FileStream fileStream = new FileStream(mapPath + "\\" + filename, FileMode.OpenOrCreate);

                    try
                    {
                        Stream inputStream = HttpContext.Current.Request.InputStream;
                        inputStream.CopyTo(fileStream);
                        context.Response.Write("{success:true, name:\"" + filename + "\", path:\"" + path + "/" + filename + "\"}");

                    }
                    catch (Exception)
                    {
                        context.Response.Write("{success:false}");
                    }
                    finally
                    {
                        fileStream.Close();
                    }

                }
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}