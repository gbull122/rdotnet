using System.Collections.Generic;
using RDotNet.R.Adapter;

namespace RDotNet.Client
{
    public interface IRObjectAPI
    {
        void PreserveObject(IRSafeHandle handle);
        void ReleaseObject(IRSafeHandle handle);
        IRSafeHandle Protect(IRSafeHandle handle);
        void Unprotect(int count);
        void UnprotectPtr(IRSafeHandle handle);
        IRSafeHandle Install(string s);
        IRSafeHandle MakeString(string s);
        IRSafeHandle AsCharacterFactor(IRSafeHandle handle);
        IRSafeHandle AllocateVector(SymbolicExpressionType type, int length);
        IRSafeHandle CoerceVector(IRSafeHandle handle, SymbolicExpressionType type);
        bool IsVector(IRSafeHandle handle);
        bool IsFrame(IRSafeHandle handle);
        bool IsS4(IRSafeHandle handle);
        int GetLength(IRSafeHandle handle);
        IRSafeHandle AllocateMatrix(SymbolicExpressionType type, int rowCount, int columnCount);
        bool IsMatrix(IRSafeHandle handle);
        int NumberOfRows(IRSafeHandle handle);
        int NumberOfColumns(IRSafeHandle handle);
        IRSafeHandle AllocateList(int length);
        bool IsList(IRSafeHandle handle);
        IRSafeHandle Evaluate(IRSafeHandle handle, IRSafeHandle environment);
        IRSafeHandle TryEvaluate(IRSafeHandle handle, IRSafeHandle environment, out bool errorOccurred);
        IRSafeHandle ParseVector(IRSafeHandle handle, int statementCount, out ParseStatus status);
        IRSafeHandle FindVar(IRSafeHandle name, IRSafeHandle environment);
        bool IsUnbound(IRSafeHandle handle);
        void SetVar(IRSafeHandle name, IRSafeHandle value, IRSafeHandle environment);
        void DefineVar(IRSafeHandle name, IRSafeHandle value, IRSafeHandle environment);
        IRSafeHandle GetAttribute(IRSafeHandle handle, IRSafeHandle name);
        IRSafeHandle SetAttribute(IRSafeHandle handle, IRSafeHandle name, IRSafeHandle value);
        IRSafeHandle DoSlot(IRSafeHandle handle, IRSafeHandle name);
        IRSafeHandle DoSlotAssign(IRSafeHandle handle, IRSafeHandle name, IRSafeHandle value);
        IRSafeHandle GetClassDefinition(string what);
        bool HasSlot(IRSafeHandle handle, IRSafeHandle name);
        bool IsEnvironment(IRSafeHandle handle);
        bool IsExpression(IRSafeHandle handle);
        bool IsSymbol(IRSafeHandle handle);
        bool IsLanguage(IRSafeHandle handle);
        bool IsFunction(IRSafeHandle handle);
        bool IsFactor(IRSafeHandle handle);
        bool IsOrdered(IRSafeHandle handle);
        IRSafeHandle LsInternal(IRSafeHandle environment, bool all);
        IRSafeHandle ApplyClosure(IRSafeHandle call, IRSafeHandle value, IRSafeHandle arguments, IRSafeHandle environment, IRSafeHandle suppliedEnvironment);
        IRSafeHandle VectorToPairList(IRSafeHandle handle);
        IRSafeHandle AllocateSEXP(SymbolicExpressionType type);
        IRSafeHandle NewEnvironment(IRSafeHandle parent);
        IRSafeHandle Cons(IRSafeHandle handle, IRSafeHandle next);
        IRSafeHandle LCons(IRSafeHandle handle, IRSafeHandle next);
        bool IsNil(IRSafeHandle handle);
        bool IsNaString(IRSafeHandle handle);
        string GetParseError();
        IRSafeHandle GetGlobalEnvironment();
        IRSafeHandle GetNames();
        void InitializeVector<T>(IRSafeHandle handle, SymbolicExpressionType type, IList<T> vector);
        IList<string> GetAttributeNames(IRSafeHandle handle);
        string GetPrintName(IRSafeHandle handle);
        void SetPrintName(IRSafeHandle handle, string value);
        IRSafeHandle GetDimNames();
        IEnumerable<IRSafeHandle> GetSymbols(IRSafeHandle handle);
        bool IsPromise(IRSafeHandle handle);
        IRSafeHandle GetFactorLevels(IRSafeHandle handle);
        IList<T> GetVectorValues<T>(IRSafeHandle handle, SymbolicExpressionType type);
        void ClearVector(IRSafeHandle handle, SymbolicExpressionType type, int length);
        void InitializeMatrix<T>(IRSafeHandle handle, SymbolicExpressionType type, T[,] matrix);
        T GetVectorValueAt<T>(IRSafeHandle handle, SymbolicExpressionType type, int index);
        void SetVectorValueAt<T>(IRSafeHandle handle, SymbolicExpressionType type, int index, T value);
        IRSafeHandle GetParentEnvironment(IRSafeHandle handle);
        IRSafeHandle GetClosureBody(IRSafeHandle handle);
        IRSafeHandle GetClosureFormals(IRSafeHandle handle);
        IRSafeHandle GetClosureEnvironment(IRSafeHandle handle);
        IRSafeHandle GetLanguageList(IRSafeHandle handle);
        T GetMatrixValueAt<T>(IRSafeHandle handle, SymbolicExpressionType type, int row, int column);
        void SetMatrixValueAt<T>(IRSafeHandle handle, SymbolicExpressionType type, int row, int column, T value);
        IRSafeHandle GetValue(IRSafeHandle handle);
        IRSafeHandle GetInternal(IRSafeHandle handle);
        IRSafeHandle GetClass(IRSafeHandle handle);
        T[,] GetMatrixValues<T>(IRSafeHandle handle, SymbolicExpressionType type);
        IRSafeHandle CreateIsolatedEnvironment();
    }
}