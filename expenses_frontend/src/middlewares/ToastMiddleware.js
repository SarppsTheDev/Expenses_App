import { newExpense, editExpense, deleteExpense, setExpensesError, newExpensesError, editExpensesError, deleteExpensesError } from '../app/expensesSlice';
import { toast } from 'react-toastify';

const ToastMiddleware = () => next => action => {
    switch (action.type) {
        case newExpense.type:
            toast.success('New expense added successfully!')
            break;
        case editExpense.type:
            toast.success('Expense edited successfully!')
            break;
        case deleteExpense.type:
            toast.success('Expense deleted successfully!')
            break;
        case setExpensesError.type:
            toast.error('Error loading expenses')
            break;
        case newExpensesError.type:
            toast.error('Error creating expense')
            break;
        case editExpensesError.type:
            toast.error('Error editing expense')
            break;
        case deleteExpensesError.type:
            toast.error('Error deleteing expenses')
            break;
        default:
            break;
    }

    return next(action);
}

export default ToastMiddleware;

