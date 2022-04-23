using DomainLayer.Entities.BookEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class BookEntitiesConfigurations : IEntityTypeConfiguration<Book>,
                                            IEntityTypeConfiguration<Author>,
                                        IEntityTypeConfiguration<BookAuthor>,
                                       IEntityTypeConfiguration<BookDetails>,
                                         IEntityTypeConfiguration<BookGenre>,
                                         IEntityTypeConfiguration<BookImage>,
                                      IEntityTypeConfiguration<BookLanguage>,
                                           IEntityTypeConfiguration<BookTag>,
                                          IEntityTypeConfiguration<Category>,
                                             IEntityTypeConfiguration<Genre>,
                                          IEntityTypeConfiguration<Language>,
                                               IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Name).IsRequired().HasMaxLength(255);
        }

        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(b => b.Name).IsRequired();
        }

        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.Property(b => b.Book).IsRequired();
        }

        public void Configure(EntityTypeBuilder<BookDetails> builder)
        {
            builder.Property(b => b.Book).HasDefaultValue(0);
        }

        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<BookImage> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<BookLanguage> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<BookTag> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<Language> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            throw new NotImplementedException();
        }
    }
}
