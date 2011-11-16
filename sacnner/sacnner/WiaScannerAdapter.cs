﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WIA;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Drawing;
using System.Drawing.Imaging;

namespace sacnner
{
    public sealed class WiaScannerAdapter : IDisposable
    {
         private CommonDialogClass _wiaManager;
         private bool _disposed; // indicates if Dispose has been called

         public WiaScannerAdapter()
         {
         }

         WiaScannerAdapter()
         {
              Dispose(false);
         }

         private CommonDialogClass WiaManager
         {
              get { return _wiaManager; }
              set { _wiaManager = value; }
         }

         [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
         public Image ScanImage(ImageFormat outputFormat, string fileName)
         {
              if (outputFormat == null)
                   throw new ArgumentNullException("outputFormat");

              FileIOPermission filePerm =  new FileIOPermission(FileIOPermissionAccess.AllAccess, fileName);
              filePerm.Demand();

              ImageFile imageObject = null;

              try
              {
                   if (WiaManager == null)
                        WiaManager = new CommonDialogClass();

                   imageObject =
                        WiaManager.ShowAcquireImage(WiaDeviceType.ScannerDeviceType,
                             WiaImageIntent.ColorIntent, WiaImageBias.MinimizeSize, 
                             outputFormat.Guid.ToString("B"), false, true, true);

                   imageObject.SaveFile(fileName);
                   return Image.FromFile(fileName);
              }
              catch (COMException ex)
              {
                   string message = "Error scanning image";
                   throw new WiaOperationException(message, ex);
              }
              finally
              {
                   if (imageObject != null)
                        Marshal.ReleaseComObject(imageObject);
              }
         }

         public void Dispose()
         {
              Dispose(true);
              GC.SuppressFinalize(this);
         }

         private void Dispose(bool disposing)
         {
              if (!_disposed)
              {
                   if (disposing)
                   {
                        // no managed resources to cleanup
                   }

                  // cleanup unmanaged resources
                  if (_wiaManager != null)
                       Marshal.ReleaseComObject(_wiaManager);

                  _disposed = true;
              }
         }
    }
}
