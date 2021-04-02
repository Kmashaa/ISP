using System;
using System.Runtime.InteropServices;

namespace Lab4
{
    class Lab4
    {

        public static void Main(string[] args)
        {
            PhysicallyInstalledSystemMemory();

            SystemInfo();

            GlobalMemoryStatus();

            DiskFreeSpace("C:\\");

            DiskFreeSpace("D:\\");

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            public ushort processorArchitecture;
            public ushort reserved;
            public uint pageSize;
            public IntPtr minimumApplicationAddress;
            public IntPtr maximumApplicationAddress;
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort processorLevel;
            public ushort processorRevision;
        }

        [DllImport("kernel32.dll")]
        public static extern void GetSystemInfo(out SYSTEM_INFO Info);

        public static void ProcessorArchitecture(ushort wProcessorArchitecture)
        {
            switch (wProcessorArchitecture)
            {
                case 0:
                    Console.WriteLine("Processor architecture: Intel x86");
                    break;
                case 6:
                    Console.WriteLine("Processor architecture:" +
                                      " Intel x64 (Intel Itanium-based)");
                    break;
                case 9:
                    Console.WriteLine("Processor architecture: " +
                                      "(AMD or Intel) x64");
                    break;
                case 5:
                    Console.WriteLine("Processor architecture: ARM");
                    break;
                case 12:
                    Console.WriteLine("Processor architecture: ARM64");
                    break;
                default:
                    Console.WriteLine("Unknown processor architecture");
                    break;
            }
        }

        public static void SystemInfo()
        {
            SYSTEM_INFO info;
            GetSystemInfo(out info);

            ProcessorArchitecture(info.processorArchitecture);
            Console.WriteLine("Page size: {0} KB", info.pageSize / 1024);
            Console.WriteLine("The number of logical processors " +
                              "in the current group: {0}", info.numberOfProcessors);
            Console.WriteLine("Processor type: {0}", info.processorType);
            Console.WriteLine("Allocation granularity: {0}", info.allocationGranularity);
            Console.WriteLine("Processor level: {0}", info.processorLevel);
            Console.WriteLine("Processor revision: {0}", info.processorRevision);

        }      
     
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out ulong TotalMemoryInKilobytes);

        static void PhysicallyInstalledSystemMemory()
        {
            ulong memoryInKilobytes;
            GetPhysicallyInstalledSystemMemory(out memoryInKilobytes);
            Console.WriteLine(memoryInKilobytes / 1024 / 1024 +
                              " GB of RAM installed.\n");
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
                                              out ulong lpFreeBytesAvailable,
                                              out ulong lpTotalNumberOfBytes,
                                              out ulong lpTotalNumberOfFreeBytes);

        static void DiskFreeSpace(string lpDirectoryName)
        {
            Console.WriteLine("\nInformation about hard disk \"{0}\"", lpDirectoryName);

            ulong FreeBytesAvailable;
            ulong TotalNumberOfBytes;
            ulong TotalNumberOfFreeBytes;

            bool success = GetDiskFreeSpaceEx(lpDirectoryName,
                                              out FreeBytesAvailable,
                                              out TotalNumberOfBytes,
                                              out TotalNumberOfFreeBytes);

            if (!success) { Console.WriteLine("Error"); }
               

            Console.WriteLine("Free gigabytes available: " +
                               FreeBytesAvailable / 1024 / 1024 / 1024);
            Console.WriteLine("Total number of gigabytes: " +
                               TotalNumberOfBytes / 1024 / 1024 / 1024);
            Console.WriteLine("Total number of free gigabytes: " +
                               TotalNumberOfFreeBytes / 1024 / 1024 / 1024);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }

        [DllImport("kernel32.dll")]
        public static extern void GlobalMemoryStatusEx(out MEMORYSTATUSEX lpBuffer);

        public static void GlobalMemoryStatus()
        {
            MEMORYSTATUSEX memoryStatus;
            memoryStatus.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            GlobalMemoryStatusEx(out memoryStatus);
            Console.WriteLine("There is {0} percent of memory in use.\n",
                               memoryStatus.dwMemoryLoad);
            Console.WriteLine("There are {0} total KB of physical memory.",
                               memoryStatus.ullTotalPhys / 1024);
            Console.WriteLine("There are {0} free  KB of physical memory.\n",
                               memoryStatus.ullAvailPhys / 1024);
            Console.WriteLine("There are {0} total KB of paging file.",
                               memoryStatus.ullTotalPageFile / 1024);
            Console.WriteLine("There are {0}  free  KB of paging file.\n",
                               memoryStatus.ullAvailPageFile / 1024);
            Console.WriteLine("There are {0} total KB of virtual memory.",
                               memoryStatus.ullTotalVirtual / 1024);
            Console.WriteLine("There are {0} free  KB of virtual memory.\n",
                               memoryStatus.ullAvailVirtual / 1024);
            Console.WriteLine("There are {0} free  KB of extended memory.",
                               memoryStatus.ullAvailExtendedVirtual / 1024);
        }
    }
}
