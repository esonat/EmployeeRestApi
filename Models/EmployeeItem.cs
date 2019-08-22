using System;

namespace EmployeeRestApi.Models{
    public class EmployeeItem{
        public long id{get;set;}
        public string firstname{get;set;}
        public string lastname{get;set;}
        public string dateofbirth{get;set;}
        public string department{get;set;}
    }
}