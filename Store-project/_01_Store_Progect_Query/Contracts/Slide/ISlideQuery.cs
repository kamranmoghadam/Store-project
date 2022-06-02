using System.Collections.Generic;

namespace _01_Store_Project_Query.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}