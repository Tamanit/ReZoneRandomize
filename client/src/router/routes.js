import Repository from "../component/Page/Repository";
import CreateUpdate from "../component/Page/CreateUpdate";
import MainPage from "../component/Page/MainPage";
import Login from "../component/Page/Login";
import Register from "../component/Page/Register";
import Statistic from "../component/Page/Statistic";
import RandomPage from "../component/Page/RandomPage";

export const routes = [
    // {path: '/boardGames', component: Repository, exact: true},
    // {path: '/boardGame/create', component: CreateUpdate, exact: true},
    // {path: '/boardGames/:id', component: CreateUpdate, exact: true},
    // {path: '/statistic', component: Statistic, exact: true},
    // {path: '/', component: MainPage, exact: false},
]

export const publicRoutes = [
    // {path: '/login', component: Login, exact: true},
    // {path: '/register', component: Register, exact: true},
    {path: '/:branchName?', component: RandomPage, exact: false}
]

