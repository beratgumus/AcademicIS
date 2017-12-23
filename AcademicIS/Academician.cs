using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicIS {
    public class Academician {
        public int Id;
        public string Name;
        public string Faculty;
        public int Faculty_id;
        public string Department;
        public int Deparment_id;
        public string Mail;
        public string Phone;
        public string Website;
        public string Detail_RTF;

        public Academician(string name, int faculty_id, int deparment_id, string mail, string phone, string website, string detail_RTF) {
            Name = name;
            Faculty_id = faculty_id;
            Deparment_id = deparment_id;
            Mail = mail;
            Phone = phone;
            Website = website;
            Detail_RTF = detail_RTF;
        }

        public Academician(int id, string name, string faculty, string department, string mail, string phone, string website, string detail_info) {
            Id = id;
            Name = name;
            Faculty = faculty;
            Department = department;
            Mail = mail;
            Phone = phone;
            Website = website;
            Detail_RTF = detail_info;
        }

        public Academician(int id, string name, string faculty, string department) {
            Id = id;
            Name = name;
            Faculty = faculty;
            Department = department;
        }

        
    }
}
