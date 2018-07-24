﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using Syncfusion.Windows.Controls.Gantt;
using System.Windows;
using System.Windows.Media;

namespace CustomMetroStyle
{
    public class ViewModel 
    {
        public ViewModel()
        {
            _metroStyleColorCollection = this.GetMetroStyles();
            _taskDetails = GetData();            
        }
    
        private ObservableCollection<Task> _taskDetails;     

        /// <summary>
        /// Gets or sets the appointment item source.
        /// </summary>
        /// <value>The appointment item source.</value>
        public ObservableCollection<Task> TaskDetails
        {
            get
            {
                return _taskDetails;
            }
            set
            {
                _taskDetails = value;
            }
        }

        private List<MetroStyleColor> _metroStyleColorCollection;

        /// <summary>
        /// Gets or sets the metro stlye color collection.
        /// </summary>
        /// <value>The metro stlye color collection.</value>
        public List<MetroStyleColor> MetroStlyeColorCollection
        {
            get
            {
                return _metroStyleColorCollection;
            }
            set
            {
                _metroStyleColorCollection = value;
            }
        }

        /// <summary>
        /// Gets the metro styles
        /// </summary>
        /// <returns></returns>
        private List<MetroStyleColor> GetMetroStyles()
        {
            List<MetroStyleColor> metroStyleColors = new List<MetroStyleColor>();
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FFFF0094"), Name = "Magenta" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FFA500FF"), Name = "Purple" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FF00AAAD"), Name = "Teal" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FF8CBE21"), Name = "Lime" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FFA55100"), Name = "Brown" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FFE771BD"), Name = "Pink" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FFF79608"), Name = "Mango" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FF18A2E7"), Name = "Blue" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FFE71400"), Name = "Red" });
            metroStyleColors.Add(new MetroStyleColor() { Brush = (Brush)new BrushConverter().ConvertFromString("#FF319A31"), Name = "Green" });
            return metroStyleColors;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Task> GetData()
        {
            var data = new ObservableCollection<Task>();
            data.Add(new Task() { Id = 1, Name = "Analysis/Planning", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 14), Complete = 40d });
            data[0].ChildTask.Add((new Task() { Id = 2, Name = "Identify Components to be Localized", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 5), Complete = 20d }));
            data[0].ChildTask.Add((new Task() { Id = 3, Name = "Ensure file localizability", StDate = new DateTime(2011, 7, 6), EndDate = new DateTime(2011, 7, 7), Complete = 20d }));
            data[0].ChildTask.Add((new Task() { Id = 4, Name = "Identify tools", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 14), Complete = 10d }));
            data[0].ChildTask.Add((new Task() { Id = 5, Name = "Test tools", StDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 8, 1), Complete = 10d }));
            data[0].ChildTask.Add((new Task() { Id = 6, Name = "Develop delivery timeline", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 8, 1), Complete = 10d }));
            data[0].ChildTask.Add((new Task() { Id = 7, Name = "Analysis complete", StDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 8, 10), Complete = 10d }));

            data.Add(new Task() { Id = 8, Name = "Production", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 14), Complete = 40d });
            data[1].ChildTask.Add((new Task() { Id = 9, Name = "Software Components", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 5), Complete = 20d, }));
            data[1].ChildTask.Add((new Task() { Id = 10, Name = "Localization Component - User Interface", StDate = new DateTime(2011, 7, 6), EndDate = new DateTime(2011, 7, 7), Complete = 20d }));
            data[1].ChildTask.Add((new Task() { Id = 11, Name = "User Assistance Components", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 14), Complete = 10d }));
            data[1].ChildTask.Add((new Task() { Id = 12, Name = "Software components complete", StDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 7, 18), Complete = 10d }));


            data.Add(new Task() { Id = 13, Name = "Quality Assurance", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 12), Complete = 40d, });
            data[2].ChildTask.Add((new Task() { Id = 14, Name = "Review project information", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 15), Complete = 20d }));
            data[2].ChildTask.Add((new Task() { Id = 15, Name = "Localization Component", StDate = new DateTime(2011, 7, 6), EndDate = new DateTime(2011, 7, 8), Complete = 20d }));
            data[2].ChildTask.Add((new Task() { Id = 16, Name = "Localization Component", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 14), Complete = 10d }));
            data[2].ChildTask.Add((new Task() { Id = 17, Name = "Localization Component", StDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 7, 18), Complete = 10d }));

            data.Add(new Task() { Id = 18, Name = "Beta Testing", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 14), Complete = 40d });
            data[3].ChildTask.Add((new Task() { Id = 19, Name = "Disseminate completed product", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 5), Complete = 20d }));
            data[3].ChildTask.Add((new Task() { Id = 20, Name = "Obtain feedback", StDate = new DateTime(2011, 7, 6), EndDate = new DateTime(2011, 7, 7), Complete = 20d }));
            data[3].ChildTask.Add((new Task() { Id = 21, Name = "Modify", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 19), Complete = 10d }));
            data[3].ChildTask.Add((new Task() { Id = 22, Name = "Test", StDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 7, 19), Complete = 10d }));
            data[3].ChildTask.Add((new Task() { Id = 23, Name = "Complete", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 19), Complete = 10d }));

            data.Add(new Task() { Id = 24, Name = "Post-Project Review", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 14), Complete = 40d });
            data[4].ChildTask.Add((new Task() { Id = 25, Name = "Finalize cost analysis", StDate = new DateTime(2011, 7, 3), EndDate = new DateTime(2011, 7, 5), Complete = 20d }));
            data[4].ChildTask.Add((new Task() { Id = 26, Name = "Analyze performance", StDate = new DateTime(2011, 7, 6), EndDate = new DateTime(2011, 7, 7), Complete = 20d }));
            data[4].ChildTask.Add((new Task() { Id = 27, Name = "Archive files", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 14), Complete = 10d }));
            data[4].ChildTask.Add((new Task() { Id = 28, Name = "Document lessons learned", StDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 7, 18), Complete = 10d }));
            data[4].ChildTask.Add((new Task() { Id = 29, Name = "Distribute to team members", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 14), Complete = 10d }));
            data[4].ChildTask.Add((new Task() { Id = 30, Name = "Post-project review complete", StDate = new DateTime(2011, 7, 10), EndDate = new DateTime(2011, 7, 14), Complete = 10d }));

            data[1].Resource.Add(new Resource() { ID = 1, Name = "Localizer" });
            data[2].Resource.Add(new Resource() { ID = 2, Name = "Technical Reviewer" });
            data[3].Resource.Add(new Resource() { ID = 3, Name = "Project Manager" });

            data[0].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 2, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[0].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 3, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[0].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 3, GanttTaskRelationship = GanttTaskRelationship.StartToStart });

            data[1].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 9, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[1].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 10, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[1].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 7, GanttTaskRelationship = GanttTaskRelationship.StartToStart });

            data[2].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 12, GanttTaskRelationship = GanttTaskRelationship.FinishToFinish });
            data[2].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 12, GanttTaskRelationship = GanttTaskRelationship.FinishToFinish });
            data[2].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 12, GanttTaskRelationship = GanttTaskRelationship.FinishToFinish });

            data[3].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 18, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[3].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 18, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[3].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 19, GanttTaskRelationship = GanttTaskRelationship.StartToStart });

            data[4].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 25, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[4].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 28, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[4].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 30, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[4].ChildTask[4].Predecessor.Add(new Predecessor() { GanttTaskIndex = 27, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            return data;
        }
    }
}