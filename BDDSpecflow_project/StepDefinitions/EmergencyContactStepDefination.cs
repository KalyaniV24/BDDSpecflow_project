using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecflow_project.StepDefinitions
{
    [Binding]
    public class EmergencyContactsStepDefinitions
    {
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            throw new PendingStepException();
        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            throw new PendingStepException();
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            throw new PendingStepException();
        }

        [When(@"I fill the add emergency contact section")]
        public void WhenIFillTheAddEmergencyContactSection(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"I click on save emergency contact")]
        public void WhenIClickOnSaveEmergencyContact()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see add emergency contact record under assigned emergency contacts")]
        public void ThenIShouldSeeAddEmergencyContactRecordUnderAssignedEmergencyContacts()
        {
            throw new PendingStepException();
        }
    }
}
