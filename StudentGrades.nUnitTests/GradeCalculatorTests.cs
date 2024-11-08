namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; }
        [SetUp]
        public void SetUp()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(99, "A")]
        [TestCase(79, "C")]
        [TestCase(50, "F")]
        [TestCase(62, "D")]
        [TestCase(53, "F")]
        [TestCase(60, "D")]
        [TestCase(46, "F")]
        [TestCase(92, "A")]
        [TestCase(72, "C")]
        [TestCase(65, "D")]
        [TestCase(93, "A")]
        [TestCase(67, "D")]
        [TestCase(76, "C")]
        [TestCase(85, "B")]
        [TestCase(69, "D")]
        [TestCase(53, "F")]
        [TestCase(80, "B")]
        [TestCase(31, "F")]
        [TestCase(50, "F")]
        [TestCase(97, "A")]
        public void GetGradeByPercentage_EqualTest(int percentage , string GradeCalculator)
        {
            //Assign
            //var percentage = 99;
            //Act
            var grade = _gradeCalculator.GetGradePercentage(percentage);
            //Assert
            Assert.That(grade, Is.EqualTo(GradeCalculator));
        }
    }
}