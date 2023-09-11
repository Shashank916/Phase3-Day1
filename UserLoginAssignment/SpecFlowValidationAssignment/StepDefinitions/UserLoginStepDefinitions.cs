using UserLoginAssignment;
using Xunit;
using TechTalk.SpecFlow;

namespace SpecFlowValidationAssignment.StepDefinitions
{
    [Binding]
    public sealed class UserLoginStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Login _login;
        private string _result;

        public UserLoginStepDefinitions(Login login)
        {
            _login = login;
        }

        [Given("the username is \"(.*)\"")]
        public void GivenTheUserNameIs(string username)
        {
            _login.Username = username == "null" ? null : username;
        }

        [Given("the password is \"(.*)\"")]
        public void GivenThePasswordIs(string password)
        {
            _login.Password = password == "null" ? null : password;
        }

        [When("I try to login")]
        public void WhenITryToLogin()
        {
            _result = _login.LoginMethod();
        }

        [Then("the message should be \"(.*)\"")]
        public void ThenTheMessageShouldBe(string result)
        {
            _result.Should().Be(result);
        }
    }
}
