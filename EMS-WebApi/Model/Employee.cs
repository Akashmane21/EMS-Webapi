using System.ComponentModel.DataAnnotations;

namespace EMS_WebApi.Model
{

 
        public class Role
    {
        [Key]
        public int Role_id { get; set; }
        public string Role_Name { get; set; }
        public string Role_Descr { get; set; }

    }

    
        public class Department
    {
        [Key]
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }

    }
   
        public class Qualification
    {
        [Key]
        public int Qualification_Id { get; set; }
        public string Qualification_Name { get; set; }
        public string Qualification_Descr { get; set; }
    }

        public class Skill
    {
        [Key]
        public int Skill_id { get; set; }
        public string Skill_Name { get; set; }
        public string Skill_Descr { get; set; }
    }
 
           public class Admins
    {
        [Key]
        public int Admin_id { get; set; }
        public string Admin_Name { get; set; }
        public string Admin_email { get; set; }
        public string password { get; set; }

    }
    public class Users
    {
        [Key]
        public int User_id { get; set; }
        public string User_Name { get; set; }
        public string User_email { get; set; }
        public string password { get; set; }

    }


        public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public DateTime DOB { get; set; }
        public int Phone_No { get; set; }
        public string Email_Id { get; set; }
        public string PanCard_No { get; set; }
        public DateTime DOJ { get; set; }
        public string Bank_Name { get; set; }
        public int Account_No { get; set; }
        public string IFSC { get; set; }
        public string Street_Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public char Is_Admin { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime Modify_Date { get; set; }
        public int Role_id { get; set; }
        public int Department_Id { get; set; }
        public int Qualification_id { get; set; }
        public string User_Name { get; set; }
    }
  
        public class Employee_Qualification
    {
        [Key]
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int Qualification_id { get; set; }
        public string Qualification_Name { get; set; }


    }


    public class Employee_Skill
    {
        [Key]
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int Skill_Id { get; set; }
        public string Skill_Name { get; set; }


    }


    public class Employee_Dependent
    {
        [Key]
        public int Dependent_Id { get; set; }
        public string Dependent_Name { get; set; }
        public string Relationship { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public int Employee_Id { get; set; }

    }
  
    public class Salary
    {
        [Key]
        public int Salary_Id { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int Basic_Pay { get; set; }
        public int HRA { get; set; }
        public int Conveyance_Allowences { get; set; }
        public int Special_Allowences { get; set; }
        public int PF { get; set; }
        public int TDS { get; set; }
        public int Gross_Salary { get; set; }
        public int Net_Salary { get; set; }
        public int Employee_Id { get; set; }



    }


    public class Employee_Salary
    {
        [Key]
        public int Id { get; set; }
        public int Basic_Pay { get; set; }
        public int HRA { get; set; }
        public int Conveyance_Allowences { get; set; }
        public int Special_Allowences { get; set; }
        public int PF { get; set; }
        public int TDS { get; set; }
        public int Gross_Salary { get; set; }
        public int Net_Salary { get; set; }
        public int Employee_Id { get; set; }

    }

}
