using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystemDal
{
   public class BatchDal
    {
        SwatiTmsEntities db = new SwatiTmsEntities();
        public List<Batch> GetBatch() {

           return  db.usp_Batch_getBatch().ToList();
        }


        public void DeleteBatch(int BatchId) {

            db.usp_Batch_DeleteBatch(BatchId);
        }


        public void UpdateBatch(Batch batch) {
          db.usp_Batch_UpdateBatch(batch.BatchCode, batch.BatchCapacity, batch.StartDate,batch.ModifiedBy,batch.ModifiedOn);
        }
        public void CreateBatch(Batch batch)
        {
           db.usp_Batch_InsertBatch( batch.BatchCode,batch.BatchCapacity, batch.CourseId, batch.StartDate, batch.CreatedBy);

        }



    }
}
