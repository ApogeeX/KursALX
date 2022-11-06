﻿using AlxCourseHomework.MaterialsAssignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework
{
    public class Page12
    {
        public static void Run()
        {
            var personalData1 = new PersonalData("Emil", "Pałczyński", 42, 1.86, "male", 80110600000);
            
            PersonalData.Present(personalData1.Name, personalData1.Surname, personalData1.Age, personalData1.Height, personalData1.Sex, personalData1.Pesel);

            var today = new Today((int)DateTime.Now.DayOfWeek, (int)DateTime.Now.Month, (int)DateTime.Now.Year);
            
            Today.Present(today.Day, today.Month, today.Year);
        } 
    }
}
