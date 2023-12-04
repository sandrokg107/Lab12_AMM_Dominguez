﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_AMM_Dominguez.Models
{
    public class TaskModel
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }

        public TaskModel(string title, bool status, string description)
        {
            Title = title;
            Status = status;
            Description = description;
        }
    }
}