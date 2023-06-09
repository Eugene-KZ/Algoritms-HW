﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Node<T>
    {
        public T value { get; set; }
        public Node<T>? next { get; set; }

        public Node(T value)
        {
            this.value = value;
        }
    }
}
