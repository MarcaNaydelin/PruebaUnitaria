using Xunit;
public class PersonTests
{
    [Fact] //Prueba unitaria
    public void Test_PersonConstructor()
    {
        // Arrange: Preparamos los datos esperados
        string expectedName = "John";
        int expectedAge = 30;

        // Act: Ejecutamos la prueba
        Person person = new Person(expectedName, expectedAge);

        // Assert: Verificamos los resultados 
        Assert.Equal(expectedName, person.Name);
        Assert.Equal(expectedAge, person.Age);
    }

    [Theory] //Metodo de una pruba unitaria se ejecutará varias veces 
            //con diferentes conjuntos de datos de entrada.

    // Datos de entrada que se usarán para ejecutar la prueba
    [InlineData("Naydelin", 21)]
    [InlineData("Ross", 18)]
    [InlineData("Carlos", 20)]
    [InlineData("Luis", 30)]
    public void Test_PersonProperties(string name, int age)
    {
        // Arrange: Preparamos los datos de prueba
        Person person = new Person(name, age);

        // Act: Obtenemos los valores actuales de las propiedades Name y Age
        string actualName = person.Name;
        int actualAge = person.Age;

        // Assert: Verificamos los resultados
        Assert.Equal(name, actualName);
        Assert.Equal(age, actualAge);
    }
}