using UnitTest.Lib.Services;

namespace UnitTest.Lib;

public class Applicationevaluator
{
    private int minAge = 18;
    private int yearsOfExpForExp = 15;
    private List<string> techStackList = new() { "C#", "RabbitMQ", "Microservice", "Visual Studio" };
    private IIdentityValidator _identityValidator;

    public Applicationevaluator(IIdentityValidator identityValidator)
    {
        _identityValidator = identityValidator;
    }
    public ApplicationResult Evaluate(JobApplication form)
    {
        if (form.Applicant.Age < minAge)
            return ApplicationResult.AutoReject;

        var validIdentity = _identityValidator.IsValid(form.Applicant.IdentityNumber);
        if(!validIdentity)
            return ApplicationResult.TransferredToHR;

        var sr = GetTechStackSimilarityRate(form.TechStackList);

        if(sr < 25)
            return ApplicationResult.AutoReject;
        if(sr > 75 && form.YearsOfExp > yearsOfExpForExp) 
            return ApplicationResult.AutoAccepted;

        return ApplicationResult.AutoAccepted;
    }
    
    private int GetTechStackSimilarityRate(List<string> techStack)
    {
        var matchedCount = techStack.Where(i => techStackList.Contains(i, StringComparer.OrdinalIgnoreCase)).Count();

        return (int)((double)matchedCount / techStackList.Count * 100);
    
    }

}



