import SendMessageForm from './SendMessageForm.js';
import MessageContainer from './MessageContainer.js';

const Chat = ({ sendMessage, messages }) => <div>
    <div className='chat'>
        <MessageContainer messages={messages} />
        <SendMessageForm sendMessage={sendMessage} />
    </div>
</div>

export default Chat;