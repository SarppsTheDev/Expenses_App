import { setExpenses, newExpense, editExpense, deleteExpense, setExpensesError, newExpensesError, editExpensesError, deleteExpensesError } from '../app/expensesSlice';
import axios from 'axios';

const axiosInstance = axios.create({
  baseURL: `${process.env.REACT_APP_BASE_URL}/Expenses`,
  // headers: {
  //   "Access-Control-Allow-Origin": "*",
  // },
});

axiosInstance.interceptors.request.use(config => {
  config.headers = { authorization: 'Bearer ' + sessionStorage.getItem('token') };
  return config;
})

export const GetExpenses = async (dispatch) => {
  try {
    // api call
    const { data } = await axiosInstance.get();
    dispatch(setExpenses(data));
  } catch {
    dispatch(setExpensesError());
  }
};

export const NewExpense = async (dispatch, expense) => {
  try {
    // api call
    const { data } = await axiosInstance.post("", expense);
    dispatch(newExpense(data));
  } catch {
    dispatch(newExpensesError());
  }
};

export const EditExpense = async (dispatch, expense) => {
  try {
    // api call
    const { data } = await axiosInstance.put("", expense);
    dispatch(editExpense(expense));
  } catch {
    dispatch(editExpensesError());
  }
};

export const DeleteExpense = async (dispatch, expense) => {
  try {
    // api call
    console.log("Deleting expense: ", expense);
    const { data } = await axiosInstance.delete("", { data: { ...expense } });
    dispatch(deleteExpense(expense));
  } catch {
    dispatch(deleteExpensesError());
  }
};
