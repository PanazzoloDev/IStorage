import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import CustomersScreen from '../Features/Customers/DefaultScreen';
import MainScreen from '../Features/Main/DefaultScreen';
import ProductsScreen from '../Features/Products/DefaultScreen';

const AppRoute = () => {

    //const Private = ({ children, roles }: { children: JSX.Element, roles: Array<string> }) => {
    //    const { authenticated, loading, user } = useAuthContext()
    //
    //    if (loading) return <p>carregando...</p>
    //
    //    if(!authenticated){
    //       return <Navigate to={'/login'} />
    //    } 
    //    
    //    if(roles.length == 0 || roles.includes(get(user, 'role'))){
    //        return <Page> {children} </Page>
    //    }
    //
    //    //toast.error('Nível não permitido, acesso negado.')
    //    return <Navigate to={'/home'} />
    //}

    return (
        <Router>
            <Routes>
                <Route path="/login" element={<div style={{ background: 'red' }} >teste</div>} />
                <Route path="/customers" element={<CustomersScreen />} />
                <Route path="/products" element={<ProductsScreen />} />
                <Route path="/" element={<MainScreen />} />
            </Routes>
        </Router>
    );
};

export default AppRoute;

//function useAuthContext(): { authenticated: any; loading: any; user: any; } {
//    throw new Error("Function not implemented.");
//}
