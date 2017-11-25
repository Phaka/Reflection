// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBePrivate.Global
namespace Phaka.Reflection
{
    using System;
    using Moq;
    using Xunit;
    
    public class ReflectorTests
    {
        public class TryFindMethod
        {
        
            public class WithoutReturnValueAndZeroParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action() {}
                }
                
            }
            
            public class WithoutReturnValueAndOneParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1) {}
                    
                    public void Action(Guid arg1) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1) {}
                }
            }
            
            public class WithoutReturnValueAndTwoParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2) {}
                    
                    public void Action(Guid arg1, Guid arg2) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2) {}
                }
            }
            
            public class WithoutReturnValueAndThreeParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3) {}
                }
            }
            
            public class WithoutReturnValueAndFourParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4) {}
                }
            }
            
            public class WithoutReturnValueAndFiveParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5) {}
                }
            }
            
            public class WithoutReturnValueAndSixParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6) {}
                }
            }
            
            public class WithoutReturnValueAndSevenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7) {}
                }
            }
            
            public class WithoutReturnValueAndEightParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8) {}
                }
            }
            
            public class WithoutReturnValueAndNineParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9) {}
                }
            }
            
            public class WithoutReturnValueAndTenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10) {}
                }
            }
            
            public class WithoutReturnValueAndElevenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11) {}
                }
                
                public class StubObject11
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11) {}
                }
            }
            
            public class WithoutReturnValueAndTwelveParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12) {}
                }
                
                public class StubObject11
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12) {}
                }
                
                public class StubObject12
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12) {}
                }
            }
            
            public class WithoutReturnValueAndThirteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13) {}
                }
                
                public class StubObject11
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13) {}
                }
                
                public class StubObject12
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13) {}
                }
                
                public class StubObject13
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13) {}
                }
            }
            
            public class WithoutReturnValueAndFourteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject14), nameof(StubObject14.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13, Guid arg14) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject11
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13, string arg14) {}
                }
                
                public class StubObject12
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13, string arg14) {}
                }
                
                public class StubObject13
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13, string arg14) {}
                }
                
                public class StubObject14
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, Guid arg14) {}
                }
            }
            
            public class WithoutReturnValueAndFifteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject14), nameof(StubObject14.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject15), nameof(StubObject15.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13, Guid arg14, Guid arg15) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject11
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject12
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13, string arg14, string arg15) {}
                }
                
                public class StubObject13
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13, string arg14, string arg15) {}
                }
                
                public class StubObject14
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, Guid arg14, string arg15) {}
                }
                
                public class StubObject15
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, Guid arg15) {}
                }
            }
            
            public class WithoutReturnValueAndSixteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject14), nameof(StubObject14.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject15), nameof(StubObject15.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject16), nameof(StubObject16.Action), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                    
                    public void Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13, Guid arg14, Guid arg15, Guid arg16) {}
                }
                
                
                public class StubObject1
                {
                    public void Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject2
                {
                    public void Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject3
                {
                    public void Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject4
                {
                    public void Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject5
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject6
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject7
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject8
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject9
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject10
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject11
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject12
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject13
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13, string arg14, string arg15, string arg16) {}
                }
                
                public class StubObject14
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, Guid arg14, string arg15, string arg16) {}
                }
                
                public class StubObject15
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, Guid arg15, string arg16) {}
                }
                
                public class StubObject16
                {
                    public void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, Guid arg16) {}
                }
            }
            
            public class WithReturnValueAndZeroParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType() { return Guid.Empty; }
                    public string Action() { return null; }
                }
                
            }
            
            public class WithReturnValueAndOneParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1) { return Guid.Empty; }
                    public string Action(string arg1) { return null; }
                    
                    public string Action(Guid arg1) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1) { return null; }
                }
            }
            
            public class WithReturnValueAndTwoParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2) { return Guid.Empty; }
                    public string Action(string arg1, string arg2) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2) { return null; }
                }
            }
            
            public class WithReturnValueAndThreeParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3) { return null; }
                }
            }
            
            public class WithReturnValueAndFourParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4) { return null; }
                }
            }
            
            public class WithReturnValueAndFiveParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5) { return null; }
                }
            }
            
            public class WithReturnValueAndSixParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6) { return null; }
                }
            }
            
            public class WithReturnValueAndSevenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7) { return null; }
                }
            }
            
            public class WithReturnValueAndEightParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8) { return null; }
                }
            }
            
            public class WithReturnValueAndNineParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9) { return null; }
                }
            }
            
            public class WithReturnValueAndTenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10) { return null; }
                }
            }
            
            public class WithReturnValueAndElevenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11) { return null; }
                }
                
                public class StubObject11
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11) { return null; }
                }
            }
            
            public class WithReturnValueAndTwelveParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12) { return null; }
                }
                
                public class StubObject11
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12) { return null; }
                }
                
                public class StubObject12
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12) { return null; }
                }
            }
            
            public class WithReturnValueAndThirteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject11
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13) { return null; }
                }
                
                public class StubObject12
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13) { return null; }
                }
                
                public class StubObject13
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13) { return null; }
                }
            }
            
            public class WithReturnValueAndFourteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject14), nameof(StubObject14.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13, Guid arg14) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject11
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject12
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13, string arg14) { return null; }
                }
                
                public class StubObject13
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13, string arg14) { return null; }
                }
                
                public class StubObject14
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, Guid arg14) { return null; }
                }
            }
            
            public class WithReturnValueAndFifteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject14), nameof(StubObject14.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject15), nameof(StubObject15.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13, Guid arg14, Guid arg15) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject11
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject12
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject13
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13, string arg14, string arg15) { return null; }
                }
                
                public class StubObject14
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, Guid arg14, string arg15) { return null; }
                }
                
                public class StubObject15
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, Guid arg15) { return null; }
                }
            }
            
            public class WithReturnValueAndSixteenParameters
            {
                public class WithExistingMethod
                {
                    
                    [Fact]
                    public void WithMatchingParameterTypes()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.True(result);
                        Assert.NotNull(method);
                    }
                    
                    [Fact]
                    public void WithInvalidFirstParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string>(typeof(StubObject1), nameof(StubObject1.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSecondParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string>(typeof(StubObject2), nameof(StubObject2.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirdParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string>(typeof(StubObject3), nameof(StubObject3.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string>(typeof(StubObject4), nameof(StubObject4.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string>(typeof(StubObject5), nameof(StubObject5.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string>(typeof(StubObject6), nameof(StubObject6.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSeventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string>(typeof(StubObject7), nameof(StubObject7.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEighthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string>(typeof(StubObject8), nameof(StubObject8.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidNinthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string>(typeof(StubObject9), nameof(StubObject9.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string>(typeof(StubObject10), nameof(StubObject10.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidEleventhParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject11), nameof(StubObject11.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidTwelfthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject12), nameof(StubObject12.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidThirteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject13), nameof(StubObject13.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFourteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject14), nameof(StubObject14.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidFifteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject15), nameof(StubObject15.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidSixteenthParameter()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject16), nameof(StubObject16.Action), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                    [Fact]
                    public void WithInvalidReturnType()
                    {
                        // Arrange
                        var target = new Reflector();
                        
                        // Act
                        var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), nameof(StubObject.ActionWithInvalidReturnType), typeof(string), out var method);
                        
                        // Assert
                        Assert.False(result);
                        Assert.Null(method);
                        
                    }
                    
                }
                
                [Fact]
                public void WithMissingMethod()
                {
                    // Arrange
                    var target = new Reflector();
                    
                    // Act
                    var result = target.TryFindMethod<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>(typeof(StubObject), "MissingAction", typeof(string), out var method);
                    
                    // Assert
                    Assert.False(result);
                    Assert.Null(method);
                    
                }
                
                public class StubObject
                {
                    public Guid ActionWithInvalidReturnType(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return Guid.Empty; }
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                    
                    public string Action(Guid arg1, Guid arg2, Guid arg3, Guid arg4, Guid arg5, Guid arg6, Guid arg7, Guid arg8, Guid arg9, Guid arg10, Guid arg11, Guid arg12, Guid arg13, Guid arg14, Guid arg15, Guid arg16) { return null; }
                }
                
                
                public class StubObject1
                {
                    public string Action(Guid arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject2
                {
                    public string Action(string arg1, Guid arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject3
                {
                    public string Action(string arg1, string arg2, Guid arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject4
                {
                    public string Action(string arg1, string arg2, string arg3, Guid arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject5
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, Guid arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject6
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, Guid arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject7
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, Guid arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject8
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, Guid arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject9
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, Guid arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject10
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, Guid arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject11
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, Guid arg11, string arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject12
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, Guid arg12, string arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject13
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, Guid arg13, string arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject14
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, Guid arg14, string arg15, string arg16) { return null; }
                }
                
                public class StubObject15
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, Guid arg15, string arg16) { return null; }
                }
                
                public class StubObject16
                {
                    public string Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, Guid arg16) { return null; }
                }
            }
            
        }
        public class TryInvokeMethod
        {
        
            [Fact]
            public void WithoutReturnValueAndZeroParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName);
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action());
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndOneParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndTwoParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndThreeParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndFourParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndFiveParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndSixParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndSevenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndEightParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndNineParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndTenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndElevenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndTwelveParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndThirteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndFourteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndFifteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithoutReturnValueAndSixteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                
                var target = new Reflector();
                
                // Act
                string methodName = nameof(IStubObject.Action);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15", "value16");
                
                // Assert
                Assert.True(result);
                m.Verify(x => x.Action("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15", "value16"));
                m.VerifyAll();
            }
            
            
            [Fact]
            public void WithReturnValueAndZeroParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function())
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function());
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndOneParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndTwoParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndThreeParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndFourParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndFiveParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndSixParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndSevenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndEightParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndNineParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndTenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndElevenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndTwelveParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndThirteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndFourteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndFifteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15"));
                m.VerifyAll();
            }
            
            [Fact]
            public void WithReturnValueAndSixteenParameters()
            {
                // Arrange
                var m = new Mock<IStubObject>();
                m.Setup(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15", "value16"))
                    .Returns("result");
                
                var target = new Reflector();
                
                // Act
                string returnValue;
                string methodName = nameof(IStubObject.Function);
                var result = target.TryInvokeMethod(m.Object, methodName, "value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15", "value16", out returnValue);
                
                // Assert
                Assert.True(result);
                Assert.Equal("result", returnValue);
                m.Verify(x => x.Function("value1", "value2", "value3", "value4", "value5", "value6", "value7", "value8", "value9", "value10", "value11", "value12", "value13", "value14", "value15", "value16"));
                m.VerifyAll();
            }
            
            
            public interface IStubObject
            {
                void Action();
                void Action(string arg1);
                void Action(string arg1, string arg2);
                void Action(string arg1, string arg2, string arg3);
                void Action(string arg1, string arg2, string arg3, string arg4);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15);
                void Action(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16);
                string Function();
                string Function(string arg1);
                string Function(string arg1, string arg2);
                string Function(string arg1, string arg2, string arg3);
                string Function(string arg1, string arg2, string arg3, string arg4);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15);
                string Function(string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10, string arg11, string arg12, string arg13, string arg14, string arg15, string arg16);
            }
        }
    }
}
