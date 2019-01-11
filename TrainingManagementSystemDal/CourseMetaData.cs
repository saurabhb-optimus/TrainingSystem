using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystemDal
{
    class CourseMetaData
    {
        [Required(ErrorMessage = "BatchId is required.")]
        public int BatchId { get; set; }


        [Required(ErrorMessage = "BatchCode is required.")]
        public string BatchCode { get; set; }



        [Required(ErrorMessage = "BatchCapacity is required.")]
        public Nullable<int> BatchCapacity { get; set; }

        [Required(ErrorMessage = "CourseId is required.")]
        public Nullable<int> CourseId { get; set; }


        public Nullable<System.DateTime> StartDate { get; set; }


        public Nullable<bool> IsActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }

        public virtual Course Course { get; set; }
    }
}
