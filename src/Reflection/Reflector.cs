namespace Phaka.Reflection
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    public class Reflector
    {
        public bool TryFindMethod(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 0
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 1
                    where parameters[0].ParameterType == typeof(T1)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 2
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 3
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 4
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 5
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 6
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 7
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 8
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 9
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 10
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 11
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 12
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 13
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 14
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                    where parameters[13].ParameterType == typeof(T14)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 15
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                    where parameters[13].ParameterType == typeof(T14)
                    where parameters[14].ParameterType == typeof(T15)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Type type, string methodName, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                let parameters = m.GetParameters()
                    where parameters.Length == 16
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                    where parameters[13].ParameterType == typeof(T14)
                    where parameters[14].ParameterType == typeof(T15)
                    where parameters[15].ParameterType == typeof(T16)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 0
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 1
                    where parameters[0].ParameterType == typeof(T1)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 2
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 3
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 4
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 5
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 6
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 7
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 8
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 9
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 10
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 11
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 12
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 13
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 14
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                    where parameters[13].ParameterType == typeof(T14)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 15
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                    where parameters[13].ParameterType == typeof(T14)
                    where parameters[14].ParameterType == typeof(T15)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Type type, string methodName, Type returnType, out MethodInfo result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = null;
            
            var candidates = from m in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)
                where m.ReturnType == returnType
                let parameters = m.GetParameters()
                    where parameters.Length == 16
                    where parameters[0].ParameterType == typeof(T1)
                    where parameters[1].ParameterType == typeof(T2)
                    where parameters[2].ParameterType == typeof(T3)
                    where parameters[3].ParameterType == typeof(T4)
                    where parameters[4].ParameterType == typeof(T5)
                    where parameters[5].ParameterType == typeof(T6)
                    where parameters[6].ParameterType == typeof(T7)
                    where parameters[7].ParameterType == typeof(T8)
                    where parameters[8].ParameterType == typeof(T9)
                    where parameters[9].ParameterType == typeof(T10)
                    where parameters[10].ParameterType == typeof(T11)
                    where parameters[11].ParameterType == typeof(T12)
                    where parameters[12].ParameterType == typeof(T13)
                    where parameters[13].ParameterType == typeof(T14)
                    where parameters[14].ParameterType == typeof(T15)
                    where parameters[15].ParameterType == typeof(T16)
                select m;
            
            result = candidates.FirstOrDefault();
            return result != null;
        }
        
        public bool TryInvokeMethod<TObject>(TObject instance, string methodName)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1>(TObject instance, string methodName, T1 arg1)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2>(TObject instance, string methodName, T1 arg1, T2 arg2)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16};
            method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult>(TObject instance, string methodName, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1>(TObject instance, string methodName, T1 arg1, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2>(TObject instance, string methodName, T1 arg1, T2 arg2, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
        public bool TryInvokeMethod<TObject, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TObject instance, string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, out TResult result)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(methodName));
            
            result = default(TResult);
            if (!TryFindMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(typeof(TObject), methodName, out var method))
            {
                return false;
            }
            
            object[] args = {arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16};
            result = (TResult)method.Invoke(instance, args);
            return true;
        }
        
    }
}
