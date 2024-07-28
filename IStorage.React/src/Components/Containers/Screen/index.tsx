import Footer from "../Footer"
import Topbar from "../Topbar"
import { ContentScreen, ScreenContainer } from "./style"

const Screen = ({...props}) => {
    return(
        <ScreenContainer>
            <Topbar/>
            <ContentScreen>
                {props.children}
            </ContentScreen>
            <Footer/>
        </ScreenContainer>
    )
}

export default Screen