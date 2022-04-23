
//public class MapperTest : Profile
//	{
//		private readonly IMapper target;

//		public MapperTest()
//		{
//			AutoMapper.Mapper.CreateMap<SourceA, Destination>();
//			AutoMapper.Mapper.CreateMap<SourceB, Destination>();
//			target = new Mapper();
//		}

//		[Fact]
//		public void Map_MapsSourceToDestinationObject_viaMapBuilder()
//		{
//			// Arrange.
//			var source = new SourceA { A = "a value" };
//			Destination destination = new DestinationProxy();

//			// Act.
//			var result = target.Map(source).To(destination);

//			// Assert.
//			result.Should().BeSameAs(destination);
//			Assert.Equal(source.A, result.A);
//			result.A.Should().Be(source.A);
//			result.B.Should().BeNull();
//		}

//		[Fact]
//		public void Map_MapsSourceToDestinationType_viaMapBuilder()
//		{
//			// Arrange.
//			var source = new SourceA { A = "a value" };

//			// Act.
//			var result = target.Map(source).To<Destination>();

//			// Assert.
//			result.A.Should().Be(source.A);
//			result.B.Should().BeNull();
//		}

//		[Fact]
//		public void Map_MapsManySourcesToDestinationObject_viaMapBuilder()
//		{
//			// Arrange.
//			var sourceA = new SourceA { A = "a value" };
//			var sourceB = new SourceB { B = "b value" };
//			Destination destination = new DestinationProxy();

//			// Act.
//			var result = target.Map(sourceA).Map(sourceB).To(destination);

//			// Assert.
//			result.Should().BeSameAs(destination);
//			result.A.Should().Be(sourceA.A);
//			result.B.Should().Be(sourceB.B);
//		}

//		[Fact]
//		public void Map_MapsManySourcesToDestinationType_viaMapBuilder()
//		{
//			// Arrange.
//			var sourceA = new SourceA { A = "a value" };
//			var sourceB = new SourceB { B = "b value" };

//			// Act.
//			var result = target.Map(sourceA).Map(sourceB).To<Destination>();

//			// Assert.
//			result.A.Should().Be(sourceA.A);
//			result.B.Should().Be(sourceB.B);
//		}

//		[Fact]
//		public void Map_MapsManySourcesToTypeOfDestination_viaMapBuilder()
//		{
//			// Arrange.
//			var sourceA = new SourceA { A = "a value" };
//			var sourceB = new SourceB { B = "b value" };

//			// Act.
//			var result = target.Map(sourceA).Map(sourceB).ToType(typeof(Destination));

//			// Assert.
//			result.Should().BeOfType<Destination>();
//			var destination = (Destination)result;
//			destination.A.Should().Be(sourceA.A);
//			destination.B.Should().Be(sourceB.B);
//		}

//		[Fact]
//		public void Map_MapsSourceToDestinationType()
//		{
//			// Arrange.
//			var source = new SourceA { A = "a value" };

//			// Act.
//			var result = target.Map<SourceA, Destination>(source);

//			// Assert.
//			result.A.Should().Be(source.A);
//			result.B.Should().BeNull();
//		}

//		[Fact]
//		public void MapTo_MapsSourceToDestinationType()
//		{
//			// Arrange.
//			var source = new SourceA { A = "a value" };

//			// Act.
//			var result = target.MapTo<Destination>(source);

//			// Assert.
//			result.A.Should().Be(source.A);
//			result.B.Should().BeNull();
//		}

//		#region Internals

//		private class SourceA
//		{
//			public string A { get; set; }
//		}

//		private class SourceB
//		{
//			public string B { get; set; }
//		}

//		private class Destination
//		{
//			public string A { get; private set; }
//			public string B { get; private set; }
//		}

//		/// <summary>
//		/// It is used to make sure that mapper works with proxies.
//		/// </summary>
//		private class DestinationProxy : Destination
//		{
//		}

//		#endregion
//	}