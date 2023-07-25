import React from "react";
import ExpenseForm from "./components/expenseForm";
import ExpenseList from "./components/expenseList";

const App = () => (
  <div style={{ width: '60%', margin: 'auto' }}>
    <h3>New Expense</h3>
    <ExpenseForm />
    <hr style = {{border: '1px solid grey'}} />
    <h3>Your Expenses</h3>
    <ExpenseList />
  </div>
)
export default App;
