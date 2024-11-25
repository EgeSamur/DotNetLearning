using UnitTest.Lib;
using Moq;
using UnitTest.Lib.Services;

namespace JobApplications.Lib.UnitTest
{
    public class ApplicationEvaluateUnitTest
    {

        [Test]
        public void Application_WithUnderAge_TransferredToAutoRejected()
        {
            // Arrange
            var evaluator = new Applicationevaluator(null);
            var form = new JobApplication()
            {
                Applicant = new Applicant()
                {
                    Age = 17
                }
            };
           // Action
           var appResult = evaluator.Evaluate(form);
            // Assert
           Assert.AreEqual(appResult, ApplicationResult.AutoReject);
        }


        [Test]
        public void Application_WithNoTechStack_TransferredToAutoRejected()
        {
            // Arrange
           
            var evaluator = new Applicationevaluator(null);
            var form = new JobApplication()
            {
                Applicant = new Applicant(),
                TechStackList = new List<string>() {""}
              
            };
            // Action
            var appResult = evaluator.Evaluate(form);
            // Assert
            Assert.AreEqual(appResult, ApplicationResult.AutoReject);
        }

        [Test]
        public void Application_WithTechStack_TransferredToAutoAccepted()
        {
            // Arrange
            var evaluator = new Applicationevaluator(null);
            var form = new JobApplication()
            {
                Applicant = new Applicant()
                {
                    Age = 21
                },
                TechStackList = new List<string>() { "C#", "RabbitMQ", "Microservice", "Visual Studio" },
                YearsOfExp =19
            };
            // Action
            var appResult = evaluator.Evaluate(form);
            // Assert
            Assert.AreEqual(appResult, ApplicationResult.AutoAccepted);
        }



        [Test]
        public void Application_MockData_SetUp()
        {
            // Arrange

            var mocValidator = new Mock<IIdentityValidator>();
            mocValidator.Setup(i => i.IsValid(It.IsAny<string>())).Returns(true);
            
            var evaluator = new Applicationevaluator(mocValidator.Object);
            //var form = new JobApplication()
            //{
            //    Applicant = new Applicant()
            //    {
            //        Age = 21,
            //        IdentityNumber = "12314213"
            //    },
            //    TechStackList = new List<string>() { "C#", "RabbitMQ", "Microservice", "Visual Studio" },
            //    YearsOfExp = 19
            //};
            //// Action
            //var appResult = evaluator.Evaluate(form);
            //// Assert
            //Assert.AreEqual(appResult, ApplicationResult.AutoAccepted);
        }



    }
}