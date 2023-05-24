﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436,CS8981
using global::System;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System.Runtime.Versioning;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{

    /// <content>
    /// Contains extern methods from "KERNEL32.dll".
    /// </content>
    //[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
    internal static partial class PInvoke
    {
        /// <summary>Closes an open object handle.</summary>
        /// <param name="hObject">A valid handle to an open object.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>. If the application is running under a debugger,  the function will throw an exception if it receives either a  handle value that is not valid  or a pseudo-handle value. This can happen if you close a handle twice, or if you  call <b>CloseHandle</b> on a handle returned by the <a href="/windows/desktop/api/fileapi/nf-fileapi-findfirstfilea">FindFirstFile</a> function instead of calling the <a href="/windows/desktop/api/fileapi/nf-fileapi-findclose">FindClose</a> function.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//handleapi/nf-handleapi-closehandle">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
      //  [SupportedOSPlatform("windows5.0")]
        internal static extern winmdroot.Foundation.BOOL CloseHandle(winmdroot.Foundation.HANDLE hObject);

        /// <inheritdoc cref="CreateJobObject(winmdroot.Security.SECURITY_ATTRIBUTES*, winmdroot.Foundation.PCWSTR)"/>
      //  [SupportedOSPlatform("windows5.1.2600")]
        internal static unsafe Microsoft.Win32.SafeHandles.SafeFileHandle CreateJobObject(winmdroot.Security.SECURITY_ATTRIBUTES? lpJobAttributes, string lpName)
        {
            fixed (char* lpNameLocal = lpName)
            {
                winmdroot.Security.SECURITY_ATTRIBUTES lpJobAttributesLocal = lpJobAttributes.HasValue ? lpJobAttributes.Value : default(winmdroot.Security.SECURITY_ATTRIBUTES);
                winmdroot.Foundation.HANDLE __result = PInvoke.CreateJobObject(lpJobAttributes.HasValue ? &lpJobAttributesLocal : null, lpNameLocal);
                return new Microsoft.Win32.SafeHandles.SafeFileHandle(__result, ownsHandle: true);
            }
        }

        /// <summary>Creates or opens a job object.</summary>
        /// <param name="lpJobAttributes">
        /// <para>A pointer to a <a href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/aa379560(v=vs.85)">SECURITY_ATTRIBUTES</a> structure that specifies the security descriptor for the job object and determines whether child processes can inherit the returned handle. If <i>lpJobAttributes</i> is <b>NULL</b>, the job object gets a default security descriptor and the handle cannot be inherited. The ACLs in the default security descriptor for a job object come from the primary or impersonation token of the creator.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-createjobobjectw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="lpName">
        /// <para>The name of the job. The name is limited to <b>MAX_PATH</b> characters. Name comparison is case-sensitive.</para>
        /// <para>If <i>lpName</i> is <b>NULL</b>, the job is created without a name. If <i>lpName</i> matches the name of an existing event, semaphore, mutex, waitable timer, or file-mapping object, the function fails and the <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a> function returns <b>ERROR_INVALID_HANDLE</b>. This occurs because these objects share the same namespace. The object can be created in a private namespace. For more information, see <a href="https://docs.microsoft.com/windows/desktop/Sync/object-namespaces">Object Namespaces</a>. <b>Terminal Services:  </b>The name can have a "Global\\" or "Local\\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\\). For more information, see <a href="https://docs.microsoft.com/windows/desktop/TermServ/kernel-object-namespaces">Kernel Object Namespaces</a>.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-createjobobjectw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a handle to the job object. The handle has the <b>JOB_OBJECT_ALL_ACCESS</b> access right. If the object existed before the function call, the function returns a handle to the existing job object and <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a> returns <b>ERROR_ALREADY_EXISTS</b>. If the function fails, the return value is NULL. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-createjobobjectw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, EntryPoint = "CreateJobObjectW", SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
       // [SupportedOSPlatform("windows5.1.2600")]
        internal static extern unsafe winmdroot.Foundation.HANDLE CreateJobObject([Optional] winmdroot.Security.SECURITY_ATTRIBUTES* lpJobAttributes, winmdroot.Foundation.PCWSTR lpName);

        /// <inheritdoc cref="OpenJobObject(uint, winmdroot.Foundation.BOOL, winmdroot.Foundation.PCWSTR)"/>
      //  [SupportedOSPlatform("windows5.1.2600")]
        internal static unsafe Microsoft.Win32.SafeHandles.SafeFileHandle OpenJobObject(uint dwDesiredAccess, winmdroot.Foundation.BOOL bInheritHandle, string lpName)
        {
            fixed (char* lpNameLocal = lpName)
            {
                winmdroot.Foundation.HANDLE __result = PInvoke.OpenJobObject(dwDesiredAccess, bInheritHandle, lpNameLocal);
                return new Microsoft.Win32.SafeHandles.SafeFileHandle(__result, ownsHandle: true);
            }
        }

        /// <summary>Opens an existing job object.</summary>
        /// <param name="dwDesiredAccess">
        /// <para>The access to the job object. This parameter can be one or more of the <a href="https://docs.microsoft.com/windows/desktop/ProcThread/job-object-security-and-access-rights">job object access rights</a>. This access right is checked against any security descriptor for the object.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-openjobobjectw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="bInheritHandle">If this value is TRUE, processes created by this process will inherit the handle. Otherwise, the processes do not inherit this handle.</param>
        /// <param name="lpName">
        /// <para>The name of the job to be opened. Name comparisons are case sensitive. This function can open objects in a private namespace. For more information, see <a href="https://docs.microsoft.com/windows/desktop/Sync/object-namespaces">Object Namespaces</a>. <b>Terminal Services:  </b>The name can have a "Global\\" or "Local\\" prefix to explicitly open the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\\). For more information, see <a href="https://docs.microsoft.com/windows/desktop/TermServ/kernel-object-namespaces">Kernel Object Namespaces</a>.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-openjobobjectw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a handle to the job. The handle provides the requested access to the job. If the function fails, the return value is <b>NULL</b>. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-openjobobjectw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, EntryPoint = "OpenJobObjectW", SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
     //   [SupportedOSPlatform("windows5.1.2600")]
        internal static extern winmdroot.Foundation.HANDLE OpenJobObject(uint dwDesiredAccess, winmdroot.Foundation.BOOL bInheritHandle, winmdroot.Foundation.PCWSTR lpName);

        /// <inheritdoc cref="SetInformationJobObject(winmdroot.Foundation.HANDLE, winmdroot.System.JobObjects.JOBOBJECTINFOCLASS, void*, uint)"/>
      //  [SupportedOSPlatform("windows5.1.2600")]
        internal static unsafe winmdroot.Foundation.BOOL SetInformationJobObject(SafeHandle hJob, winmdroot.System.JobObjects.JOBOBJECTINFOCLASS JobObjectInformationClass, void* lpJobObjectInformation, uint cbJobObjectInformationLength)
        {
            bool hJobAddRef = false;
            try
            {
                winmdroot.Foundation.HANDLE hJobLocal;
                if (hJob is object)
                {
                    hJob.DangerousAddRef(ref hJobAddRef);
                    hJobLocal = (winmdroot.Foundation.HANDLE)hJob.DangerousGetHandle();
                }
                else
                    hJobLocal = default(winmdroot.Foundation.HANDLE);
                winmdroot.Foundation.BOOL __result = PInvoke.SetInformationJobObject(hJobLocal, JobObjectInformationClass, lpJobObjectInformation, cbJobObjectInformationLength);
                return __result;
            }
            finally
            {
                if (hJobAddRef)
                    hJob.DangerousRelease();
            }
        }

        /// <summary>Sets limits for a job object.</summary>
        /// <param name="hJob">
        /// <para>A handle to the job whose limits are being set. The <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-createjobobjecta">CreateJobObject</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-openjobobjecta">OpenJobObject</a> function returns this handle. The handle must have the <b>JOB_OBJECT_SET_ATTRIBUTES</b> access right. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/job-object-security-and-access-rights">Job Object Security and Access Rights</a>.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-setinformationjobobject#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="JobObjectInformationClass"></param>
        /// <param name="lpJobObjectInformation">The limits or job state to be set for the job. The format of this data depends on the value of <i>JobObjectInfoClass</i>.</param>
        /// <param name="cbJobObjectInformationLength">The size of the job information being set, in bytes.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-setinformationjobobject">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
      //  [SupportedOSPlatform("windows5.1.2600")]
        internal static extern unsafe winmdroot.Foundation.BOOL SetInformationJobObject(winmdroot.Foundation.HANDLE hJob, winmdroot.System.JobObjects.JOBOBJECTINFOCLASS JobObjectInformationClass, void* lpJobObjectInformation, uint cbJobObjectInformationLength);

        /// <inheritdoc cref="SetIoRateControlInformationJobObject(winmdroot.Foundation.HANDLE, winmdroot.System.JobObjects.JOBOBJECT_IO_RATE_CONTROL_INFORMATION*)"/>
      //  [SupportedOSPlatform("windows10.0.10240")]
        //internal static unsafe uint SetIoRateControlInformationJobObject(SafeHandle hJob, in winmdroot.System.JobObjects.JOBOBJECT_IO_RATE_CONTROL_INFORMATION IoRateControlInfo)
        //{
        //    bool hJobAddRef = false;
        //    try
        //    {
        //        fixed (winmdroot.System.JobObjects.JOBOBJECT_IO_RATE_CONTROL_INFORMATION* IoRateControlInfoLocal = &IoRateControlInfo)
        //        {
        //            winmdroot.Foundation.HANDLE hJobLocal;
        //            if (hJob is object)
        //            {
        //                hJob.DangerousAddRef(ref hJobAddRef);
        //                hJobLocal = (winmdroot.Foundation.HANDLE)hJob.DangerousGetHandle();
        //            }
        //            else
        //                hJobLocal = default(winmdroot.Foundation.HANDLE);
        //            uint __result = PInvoke.SetIoRateControlInformationJobObject(hJobLocal, IoRateControlInfoLocal);
        //            return __result;
        //        }
        //    }
        //    finally
        //    {
        //        if (hJobAddRef)
        //            hJob.DangerousRelease();
        //    }
        //}

        /// <summary>Sets I/O limits on a job object.</summary>
        /// <param name="hJob">A handle to the job on which to set I/O limits. Get this handle from the <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-createjobobjecta">CreateJobObject</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-openjobobjecta">OpenJobObject</a> function. The handle must have the <b>JOB_OBJECT_SET_ATTRIBUTES</b> access right. For more information about access rights, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/job-object-security-and-access-rights">Job Object Security and Access Rights</a>.</param>
        /// <param name="IoRateControlInfo">A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/jobapi2/ns-jobapi2-jobobject_io_rate_control_information">JOBOBJECT_IO_RATE_CONTROL_INFORMATION</a> structure that specifies the I/O limits to set for the job.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-setioratecontrolinformationjobobject">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
       // [DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
        //[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
     //   [SupportedOSPlatform("windows10.0.10240")]
       // internal static extern unsafe uint SetIoRateControlInformationJobObject(winmdroot.Foundation.HANDLE hJob, winmdroot.System.JobObjects.JOBOBJECT_IO_RATE_CONTROL_INFORMATION* IoRateControlInfo);

        /// <inheritdoc cref="TerminateJobObject(winmdroot.Foundation.HANDLE, uint)"/>
      //  [SupportedOSPlatform("windows5.1.2600")]
        internal static unsafe winmdroot.Foundation.BOOL TerminateJobObject(SafeHandle hJob, uint uExitCode)
        {
            bool hJobAddRef = false;
            try
            {
                winmdroot.Foundation.HANDLE hJobLocal;
                if (hJob is object)
                {
                    hJob.DangerousAddRef(ref hJobAddRef);
                    hJobLocal = (winmdroot.Foundation.HANDLE)hJob.DangerousGetHandle();
                }
                else
                    hJobLocal = default(winmdroot.Foundation.HANDLE);
                winmdroot.Foundation.BOOL __result = PInvoke.TerminateJobObject(hJobLocal, uExitCode);
                return __result;
            }
            finally
            {
                if (hJobAddRef)
                    hJob.DangerousRelease();
            }
        }

        /// <summary>Terminates all processes currently associated with the job.</summary>
        /// <param name="hJob">
        /// <para>A handle to the job whose processes will be terminated. The <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-createjobobjecta">CreateJobObject</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-openjobobjecta">OpenJobObject</a> function returns this handle. This handle must have the JOB_OBJECT_TERMINATE access right. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/job-object-security-and-access-rights">Job Object Security and Access Rights</a>. The handle for each process in the job object must have the PROCESS_TERMINATE access right. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/process-security-and-access-rights">Process Security and Access Rights</a>.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-terminatejobobject#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="uExitCode">
        /// <para>The exit code to be used by all processes and threads in the job object. Use the <a href="https://docs.microsoft.com/windows/desktop/api/processthreadsapi/nf-processthreadsapi-getexitcodeprocess">GetExitCodeProcess</a> function to retrieve each process's exit value. Use the <a href="https://docs.microsoft.com/windows/desktop/api/processthreadsapi/nf-processthreadsapi-getexitcodethread">GetExitCodeThread</a> function to retrieve each thread's exit value.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-terminatejobobject#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-terminatejobobject">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
     //   [SupportedOSPlatform("windows5.1.2600")]
        internal static extern winmdroot.Foundation.BOOL TerminateJobObject(winmdroot.Foundation.HANDLE hJob, uint uExitCode);

        /// <inheritdoc cref="AssignProcessToJobObject(winmdroot.Foundation.HANDLE, winmdroot.Foundation.HANDLE)"/>
    //    [SupportedOSPlatform("windows5.1.2600")]
        internal static unsafe winmdroot.Foundation.BOOL AssignProcessToJobObject(SafeHandle hJob, SafeHandle hProcess)
        {
            bool hJobAddRef = false;
            bool hProcessAddRef = false;
            try
            {
                winmdroot.Foundation.HANDLE hJobLocal;
                if (hJob is object)
                {
                    hJob.DangerousAddRef(ref hJobAddRef);
                    hJobLocal = (winmdroot.Foundation.HANDLE)hJob.DangerousGetHandle();
                }
                else
                    hJobLocal = default(winmdroot.Foundation.HANDLE);
                winmdroot.Foundation.HANDLE hProcessLocal;
                if (hProcess is object)
                {
                    hProcess.DangerousAddRef(ref hProcessAddRef);
                    hProcessLocal = (winmdroot.Foundation.HANDLE)hProcess.DangerousGetHandle();
                }
                else
                    hProcessLocal = default(winmdroot.Foundation.HANDLE);
                winmdroot.Foundation.BOOL __result = PInvoke.AssignProcessToJobObject(hJobLocal, hProcessLocal);
                return __result;
            }
            finally
            {
                if (hJobAddRef)
                    hJob.DangerousRelease();
                if (hProcessAddRef)
                    hProcess.DangerousRelease();
            }
        }

        /// <summary>Assigns a process to an existing job object.</summary>
        /// <param name="hJob">
        /// <para>A handle to the job object to which the process will be associated. The <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-createjobobjecta">CreateJobObject</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-openjobobjecta">OpenJobObject</a> function returns this handle. The handle must have the JOB_OBJECT_ASSIGN_PROCESS access right. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/job-object-security-and-access-rights">Job Object Security and Access Rights</a>.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-assignprocesstojobobject#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="hProcess">
        /// <para>A handle to the process to associate with the job object. The handle must have the PROCESS_SET_QUOTA and PROCESS_TERMINATE access rights. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/process-security-and-access-rights">Process Security and Access Rights</a>. If the process is already associated with a job, the job specified by <i>hJob</i> must be empty or it must be in the hierarchy of nested jobs to which the process already belongs, and it cannot have UI limits set (<a href="https://docs.microsoft.com/windows/desktop/api/jobapi2/nf-jobapi2-setinformationjobobject">SetInformationJobObject</a> with <b>JobObjectBasicUIRestrictions</b>). For more information, see Remarks. <b>Windows 7, Windows Server 2008 R2, Windows XP with SP3, Windows Server 2008, Windows Vista and Windows Server 2003:  </b>The process must not already be assigned to a job; if it is, the function fails with ERROR_ACCESS_DENIED. This behavior changed starting in Windows 8 and Windows Server 2012. <b>Terminal Services:  </b>All processes within a job must run within the same session as the job.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-assignprocesstojobobject#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi2/nf-jobapi2-assignprocesstojobobject">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
     //   [SupportedOSPlatform("windows5.1.2600")]
        internal static extern winmdroot.Foundation.BOOL AssignProcessToJobObject(winmdroot.Foundation.HANDLE hJob, winmdroot.Foundation.HANDLE hProcess);

        /// <inheritdoc cref="IsProcessInJob(winmdroot.Foundation.HANDLE, winmdroot.Foundation.HANDLE, winmdroot.Foundation.BOOL*)"/>
      //  [SupportedOSPlatform("windows5.1.2600")]
        internal static unsafe winmdroot.Foundation.BOOL IsProcessInJob(SafeHandle ProcessHandle, SafeHandle JobHandle, out winmdroot.Foundation.BOOL Result)
        {
            bool ProcessHandleAddRef = false;
            bool JobHandleAddRef = false;
            try
            {
                fixed (winmdroot.Foundation.BOOL* ResultLocal = &Result)
                {
                    winmdroot.Foundation.HANDLE ProcessHandleLocal;
                    if (ProcessHandle is object)
                    {
                        ProcessHandle.DangerousAddRef(ref ProcessHandleAddRef);
                        ProcessHandleLocal = (winmdroot.Foundation.HANDLE)ProcessHandle.DangerousGetHandle();
                    }
                    else
                        ProcessHandleLocal = default(winmdroot.Foundation.HANDLE);
                    winmdroot.Foundation.HANDLE JobHandleLocal;
                    if (JobHandle is object)
                    {
                        JobHandle.DangerousAddRef(ref JobHandleAddRef);
                        JobHandleLocal = (winmdroot.Foundation.HANDLE)JobHandle.DangerousGetHandle();
                    }
                    else
                        JobHandleLocal = default(winmdroot.Foundation.HANDLE);
                    winmdroot.Foundation.BOOL __result = PInvoke.IsProcessInJob(ProcessHandleLocal, JobHandleLocal, ResultLocal);
                    return __result;
                }
            }
            finally
            {
                if (ProcessHandleAddRef)
                    ProcessHandle.DangerousRelease();
                if (JobHandleAddRef)
                    JobHandle.DangerousRelease();
            }
        }

        /// <summary>Determines whether the process is running in the specified job.</summary>
        /// <param name="ProcessHandle">
        /// <para>A handle to the process to be tested. The handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/process-security-and-access-rights">Process Security and Access Rights</a>. <b>Windows Server 2003 and Windows XP:  </b>The handle must have the PROCESS_QUERY_INFORMATION access right.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi/nf-jobapi-isprocessinjob#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="JobHandle">
        /// <para>A handle to the job. If this parameter is NULL, the function tests if the process is running under any job. If this parameter is not NULL, the handle must have the JOB_OBJECT_QUERY access right. For more information, see <a href="https://docs.microsoft.com/windows/desktop/ProcThread/job-object-security-and-access-rights">Job Object Security and Access Rights</a>.</para>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi/nf-jobapi-isprocessinjob#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name="Result">A pointer to a value that receives TRUE if the process is running in the job, and FALSE otherwise.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href="https://docs.microsoft.com/windows/win32/api//jobapi/nf-jobapi-isprocessinjob">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    //    [SupportedOSPlatform("windows5.1.2600")]
        internal static extern unsafe winmdroot.Foundation.BOOL IsProcessInJob(winmdroot.Foundation.HANDLE ProcessHandle, winmdroot.Foundation.HANDLE JobHandle, winmdroot.Foundation.BOOL* Result);
    }
}