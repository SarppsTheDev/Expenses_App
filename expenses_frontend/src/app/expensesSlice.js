import { createSlice, createAction } from "@reduxjs/toolkit";

export const setExpensesError = createAction('setExpensesError');
export const newExpensesError = createAction('newExpensesError');
export const editExpensesError = createAction('editExpensesError');
export const deleteExpensesError = createAction('deleteExpensesError');

export const expensesSlice = createSlice({
  name: "expenses",
  initialState: {
    expenses: [],
  },
  reducers: {
    setExpenses: (state, action) => {
      return { ...state, expenses: [...action.payload] };
    },
    newExpense: (state, action) => {
      return { ...state, expenses: [...action.payload, ...state.expenses] };
    },
    editExpense: (state, action) => {
      var expenses = state.expenses.map((expense) => {
        if (expense.id === action.payload.id) {
          expense = action.payload;
        }
        return expense;
      });
    },
    deleteExpense: (state, action) => {
      var expenses = state.expenses.filter(
        (expense) => expense.id !== action.payload.id
      );
      return { ...state, expenses: [...expenses] };
    },
  },
});

export const { setExpenses, newExpense, editExpense, deleteExpense } =
  expensesSlice.actions;

export default expensesSlice.reducer;
