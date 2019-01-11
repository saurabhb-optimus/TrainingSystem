using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystemDal
{
    class BatchMetedata
    {
        [Required(ErrorMessage = "BatchId is required.")]
        public int BatchId { get; set; }


        [Required(ErrorMessage = "BatchCode is required.")]
        public string BatchCode { get; set; }



        [Required(ErrorMessage = "BatchCapacity is required.")]
        public Nullable<int> BatchCapacity { get; set; }




        [Required(ErrorMessage = "CourseId is required.")]
        public Nullable<int> CourseId { get; set; }



        [Required(ErrorMessage = "this field is required .")]
        public Nullable<System.DateTime> StartDate { get; set; }


        public Nullable<bool> IsActive { get; set; }

        [Required(ErrorMessage = "this field is required .")]
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }

        [Required(ErrorMessage ="this fiels is required.")]
        public string ModifiedBy { get; set; }




        public Nullable<System.DateTime> ModifiedOn { get; set; }

        public virtual Course Course { get; set; }
    }
}
