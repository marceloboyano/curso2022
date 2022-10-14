using System.ComponentModel.DataAnnotations;
using static challenge.DTOs.Peliculas.MoviesDto;

namespace TestChallenge
{
    public class MovieValidationTests
    {
        [Fact]
        public void Movie_Should_Contain_Title_For_Creation()
        {
            var modelInvalid = new MoviesForCreationDTO()
            {
                Title = null,
                CreationDate = DateTime.Today,
                Image = "test",
                Rating = 1
            };

            var validationResult = ValidateModel(modelInvalid);

            Assert.True(validationResult.Any(vr => vr.MemberNames.Contains("Title")));
        }



        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void Movie_Should_Contain_Qualification_Between_1_5(int rating)
        {
            var modelInvalid = new MoviesForCreationDTO()
            {
                Title = "test",
                CreationDate = DateTime.Today,
                Image = "test",
                Rating = rating
            };

            var validationResult = ValidateModel(modelInvalid);

            if(rating == 0)
            {
                Assert.True(validationResult?.Any(vr => vr.MemberNames.Contains("Rating")));
            }

            if (rating == 5)
            {
                Assert.True(validationResult?.Count == 0);
            }
        }



        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);            
            Validator.TryValidateObject(model, ctx, validationResults, true);
            return validationResults;
        }

    }
}
