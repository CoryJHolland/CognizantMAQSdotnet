﻿//--------------------------------------------------
// <copyright file="BaseUnitTestSteps.cs" company="Cognizant">
//  Copyright 2022 Cognizant, All rights Reserved
// </copyright>
// <summary>TestSteps class that inherits from BaseTestSteps</summary>
//--------------------------------------------------
using CognizantSoftvision.Maqs.BaseTest;
using CognizantSoftvision.Maqs.SpecFlow.TestSteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowExtUnitTests.Steps
{
    /// <summary>
    /// Base unit test steps
    /// </summary>
    [Binding]
    [DoNotParallelize]
    public class BaseUnitTestSteps : BaseTestSteps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnitTestSteps" /> class
        /// </summary>
        /// <param name="context">The context to pass to the base class</param>
        protected BaseUnitTestSteps(ScenarioContext context) : base(context)
        {
        }

        /// <summary>
        /// Class is instantiated
        /// </summary>
        [Given(@"class BaseTestSteps")]
        public void GivenClass()
        {
            Assert.IsNotNull(this);
        }

        /// <summary>
        /// Test object exists
        /// </summary>
        [Then(@"BaseTestSteps TestObject is not null")]
        public void ThenTestObjectIsNotNull()
        {
            Assert.IsNotNull(this.TestObject, "TestObject for BaseTestSteps class is null.");
        }

        /// <summary>
        /// Test object exists
        /// </summary>
        [Then(@"TestObject is type BaseTestSteps")]
        public void AndTestObjectIsTypeBaseTestSteps()
        {
            Assert.IsTrue(this.TestObject.GetType().Equals(typeof(BaseTestObject)), $"TestObject for BaseTestSteps class is the wrong type : {this.TestObject.GetType()}.");
        }

        /// <summary>
        /// ScenarioContext exists
        /// </summary>
        [Then(@"BaseTestSteps ScenarioContext is not null")]
        public void ThenScenarioContextIsNotNull()
        {
            Assert.IsNotNull(this.LocalScenarioContext, "ScenarioContext for BaseTestSteps class is null.");
        }

        /// <summary>
        /// ScenarioContext exists
        /// </summary>
        [Then(@"ScenarioContext is type ScenarioContext")]
        public void AndScenarioContextIsTypeBaseTestSteps()
        {
            Assert.IsTrue(this.LocalScenarioContext.GetType().Equals(typeof(ScenarioContext)), $"ScenarioContext for BaseTestSteps class is the wrong type : {this.LocalScenarioContext.GetType()}.");
        }
    }
}
