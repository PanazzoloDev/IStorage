import Footer from "../Footer"
import Topbar from "../Topbar"
import { ContentScreen } from "./style"

const Screen = ({...props}) => {
    return(
        <>
            <Topbar/>
            <ContentScreen>
                {props.children}
            </ContentScreen>
            <Footer/>
        </>

    )
}

export default Screen