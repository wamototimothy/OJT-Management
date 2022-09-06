
﻿using System.ComponentModel;




namespace OJT_Management.Models

{
    public class Attendance
    {
        public int Id { get; set; }   

        public string? Name { get; set; }
       
        [DisplayName("Attendance Date")]
        public DateTime AttendanceDate { get; set; }
        
        
        
    }
}
