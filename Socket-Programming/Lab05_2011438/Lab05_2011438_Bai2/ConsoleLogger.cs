﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab05_2011438_Bai2
{
    class ConsoleLogger : ILogger
    {
        private static Mutex mutex = new Mutex();
        public void writeEntry(ArrayList entry)
        {
            mutex.WaitOne();
            IEnumerator line = entry.GetEnumerator();
            while (line.MoveNext())
                Console.WriteLine(line.Current);
            Console.WriteLine();
            mutex.ReleaseMutex();
        }
        public void writeEntry(String entry)
        {
            mutex.WaitOne();
            Console.WriteLine(entry);
            Console.WriteLine();
            mutex.ReleaseMutex();
        }
    }
}
