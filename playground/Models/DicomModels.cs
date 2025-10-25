
public record DicomStudy(
    string StudyInstanceUID,
    string PatientID,
    string Modality,
    DateTime StudyDate,
    int NumberOfImages
);

public class DicomService
{
    public List<DicomStudy> GetStudiesByModality(List<DicomStudy> studies, string modality)
    {
        return studies.Where(s => s.Modality == modality).ToList();
    }
}
