using Library.Constants;
using Library.Enums;
using Library.Exception;
using Library.Utils;

namespace Library
{
    public class FileLibrary
    {
        ServiceObject service;
        FileHandler readFilerHndlr;
        FileHandler writeFilerHndlr;

        FileTypeEnum srcFileType ;
        FileTypeEnum destFileType ;

        public FileLibrary(ServiceObject serviceObject)
        {
            srcFileType = Helper.GetFileType(serviceObject.src);
            destFileType = Helper.GetFileType(serviceObject.dst);

            Validate();

            service = serviceObject;
            readFilerHndlr = (FileHandler)GetInstance(FileMapping.handlerMapping[srcFileType.ToString()]);
            writeFilerHndlr = (FileHandler)GetInstance(FileMapping.handlerMapping[destFileType.ToString()]);
        }

        private void Validate()
        {
            if (srcFileType == FileTypeEnum.json && destFileType == FileTypeEnum.xml || 
                srcFileType == FileTypeEnum.xml && destFileType == FileTypeEnum.json)
            {
                throw new LibException(ErrorConstants.INVALIDFILE_ERR);
            }
        }

        public ResponseData WriteToFile()
        {
            ResponseData responseData = new ResponseData();

            try
            {
                readFilerHndlr.Read(service.src);
                writeFilerHndlr.Write(readFilerHndlr.GetContent(), service.dst);

                responseData.statusCode = StatusCode.Success;
                responseData.message = Constants.Constants.WRITE_SUCCESS;
            }
            catch (LibException ex)
            {
                responseData.statusCode = StatusCode.Fail;
                responseData.message = ex.Message;
            }

            return responseData;
        }

        private object GetInstance(string strFullyQualifiedName)
        {
            return System.Reflection.Assembly.GetExecutingAssembly().CreateInstance($"Library.{strFullyQualifiedName}");
        }

    }
}
