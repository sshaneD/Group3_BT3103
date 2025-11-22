using System.Data;
using System.Data.SqlClient;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class MedicalRecordRepository
    {
        private string CONNECTIONSTRING = ConfigurationHelper.GetConnectionString();
        public void AddMedicalRecord(MedicalRecordModel medicalRecord)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AddMedicalRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", medicalRecord.PatientID);
                    cmd.Parameters.AddWithValue("@RecordDate", medicalRecord.RecordDate);
                    cmd.Parameters.AddWithValue("@Diagnosis", medicalRecord.Diagnosis);
                    cmd.Parameters.AddWithValue("@Notes", medicalRecord.Notes);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddTreatment(TreatmentModel treatment)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AddTreatment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID", treatment.RecordID);
                    cmd.Parameters.AddWithValue("@TreatmentType", treatment.TreatmentType);
                    cmd.Parameters.AddWithValue("@Price", treatment.Price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddMedication (MedicationModel medication)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AddMedication", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID", medication.RecordID);
                    cmd.Parameters.AddWithValue("@MedicationName", medication.MedicationName);
                    cmd.Parameters.AddWithValue("@FrequencyCount", medication.FrequencyCount);
                    cmd.Parameters.AddWithValue("@FrequencyValue", medication.FrequencyValue);
                    cmd.Parameters.AddWithValue("@FrequencyType", medication.FrequencyType);
                    cmd.Parameters.AddWithValue("@Duration", medication.Duration);
                    cmd.Parameters.AddWithValue("@Price", medication.Price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetNextMedicalRecordID()
        {
            int nextID = 0;
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetNextMedicalRecordID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    nextID = (int)cmd.ExecuteScalar();
                }
            }
            return nextID;
        }
        public MedicalRecordModel GetMedicalRecordByID(int RecordID)
        {
            MedicalRecordModel medicalRecord = new MedicalRecordModel();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetMedicalRecordByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID", RecordID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            medicalRecord.RecordID = reader.GetInt32(0);
                            medicalRecord.AdmissionID = reader.GetInt32(1);
                            medicalRecord.PatientID = reader.GetInt32(2);
                            medicalRecord.RecordDate = reader.GetDateTime(3);
                            medicalRecord.Diagnosis = reader.GetString(4);
                            medicalRecord.Notes = reader.GetString(5);
                        }
                    }
                }
            }
            return medicalRecord;
        }
        public TreatmentModel GetTreatmentByRecordID(int RecordID)
        {
            TreatmentModel treatment = new TreatmentModel();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetTreatmentByRecordID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID", RecordID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            treatment.TreatmentID = reader.GetInt32(0);
                            treatment.RecordID = reader.GetInt32(1);
                            treatment.TreatmentType = reader.GetString(2);
                            treatment.Price = reader.GetDecimal(3);
                        }
                    }
                }
            }
            return treatment;
        }
        public MedicationModel GetMedicationByRecordID(int RecordID)
        {
            MedicationModel medication = new MedicationModel();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetMedicationByRecordID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID", RecordID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            medication.MedicationID = reader.GetInt32(0);
                            medication.RecordID = reader.GetInt32(1);
                            medication.MedicationName = reader.GetString(2);
                            medication.FrequencyCount = reader.GetInt32(3);
                            medication.FrequencyValue = reader.GetInt32(4);
                            medication.FrequencyType = reader.GetString(5);
                            medication.Duration = reader.GetInt32(6);
                            medication.Price = reader.GetDecimal(7);
                        }
                    }
                }
            }
            return medication;
        }
        public List<MedicalRecordModel> GetPatientMedicalRecords(int PatientID)
        {
            List<MedicalRecordModel> medicalRecords = new List<MedicalRecordModel>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetPatientMedicalRecords", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicalRecords.Add(new MedicalRecordModel()
                            {
                                RecordID = reader.GetInt32(0),
                                AdmissionID = reader.GetInt32(1),
                                PatientID = reader.GetInt32(2),
                                RecordDate = reader.GetDateTime(3),
                                Diagnosis = reader.GetString(4),
                                Notes = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return medicalRecords;
        }
        public void DeleteMedicalRecordByID(int RecordID)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteMedicalRecordByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID", RecordID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
