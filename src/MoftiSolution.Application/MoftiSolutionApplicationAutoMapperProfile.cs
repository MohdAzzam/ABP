using AutoMapper;
using MoftiSolution.Books;

namespace MoftiSolution;

public class MoftiSolutionApplicationAutoMapperProfile : Profile
{
    public MoftiSolutionApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
