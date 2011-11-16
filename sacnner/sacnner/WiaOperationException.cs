using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using WIA;

namespace sacnner
{
    public enum WiaScannerError : uint
    {
        LibraryNotInstalled = 0x80040154,
        OutputFileExists = 0x80070050,
        ScannerNotAvailable = 0x80210015,
        OperationCancelled = 0x80210064
    }

    [Serializable]
    class WiaOperationException : Exception
    {
        private WiaScannerError _errorCode;

        public WiaOperationException(WiaScannerError errorCode)
            : base()
        {
            ErrorCode = errorCode;
        }

        public WiaOperationException(string message, WiaScannerError errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public WiaOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
            COMException comException = innerException as COMException;

            if (comException != null)
                ErrorCode = (WiaScannerError)comException.ErrorCode;
        }

        public WiaOperationException(string message, Exception innerException, WiaScannerError errorCode)
            : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        public WiaOperationException(System.Runtime.Serialization.SerializationInfo info,
             System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            info.AddValue("ErrorCode", (uint)_errorCode);
        }

        public WiaScannerError ErrorCode
        {
            get { return _errorCode; }
            protected set { _errorCode = value; }
        }

        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info,
             System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            ErrorCode = (WiaScannerError)info.GetUInt32("ErrorCode");
        }
    }



}
