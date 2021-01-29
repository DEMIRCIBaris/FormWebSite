using FormWebSite.Entities.DTO.EducationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Entities.DTO.AppUserDTO
{
    public class UserUpdateDto
    {
        public int GenderId { get; set; }
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public DateTime? BirthDay { get; set; }
        public int Book { get; set; }
        public int ClassroomTrainings { get; set; }
        public int Master { get; set; }
        public int OnTheJob { get; set; }
        public int Other { get; set; }
        public int TotalQuality { get { return (Book + ClassroomTrainings + Master + OnTheJob + Other); } }
        public string OtherExplanation { get; set; }
        public bool aydin{ get; set; }
        public bool riza { get; set; }
    }
}
