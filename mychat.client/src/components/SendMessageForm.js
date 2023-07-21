import { Form, Button, FormControl, InputGroup } from 'react-bootstrap';
import { useState } from 'react';


const SendMessageForm = ({ sendMessage }) => {
    const [message, setMessage] = useState('');

    return <Form
    onSubmit={e => {
        e.preventDefault();
        sendMessage(message);
        setMessage('');
    }}>

    <InputGroup className="mb-3">
        <FormControl type="user"
          placeholder="Type a message..."
          onChange={e => setMessage(e.target.value)} value={message}
          aria-label="Recipient's username"
          aria-describedby="basic-addon2"
        />
        <Button variant="outline-secondary" type="submit" id="button-addon2" disabled={!message}>
          Send
        </Button>
      </InputGroup>
</Form>

}

export default SendMessageForm;