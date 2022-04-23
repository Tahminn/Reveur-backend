using AutoMapper;

namespace ServiceLayer.Utilities.Extensions
{
    public static class Extension
    {

        public static TDestination Map<TDestination>(this IMapper mapper, params object[] source) where TDestination : class
        {
            TDestination destination = mapper.Map<TDestination>(source.FirstOrDefault());

            foreach (var src in source.Skip(1))
                destination = (TDestination)mapper.Map(src, destination);

            return destination;
        }

        public static TDestination Map<TDestination>(this IMapper mapper, TDestination destination, params object[] source) where TDestination : class
        {
            foreach (var src in source)
                destination = (TDestination)mapper.Map(src, destination);

            return destination;
        }
    }
}
