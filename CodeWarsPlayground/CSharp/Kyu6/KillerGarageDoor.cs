namespace CodeWarsPlayground.CSharp.Kyu6
{
    public class KillerGarageDoor
    {
        public enum EventState { 
        Nothing,
        Open,
        OpenPause,
        Close,
        ClosePause,
        }
        public string ProcessEvents(string events)
        {
            int counter = 0;
            string result = "";
            var State = EventState.Nothing;

            for (int i = 0; i < events.Length; i++)
            {
                switch (events[i])
                {
                    case 'P': {
                            switch (State)
                            {
                                case EventState.Nothing:
                                    {
                                        State= EventState.Open;
                                        result +=  (++counter).ToString();
                                        break;
                                    }
                                case EventState.Open:
                                    {
                                        if (counter == 5)
                                        {
                                            State = EventState.Close;
                                            result += (--counter).ToString();
                                            break;
                                        }
                                        else
                                        {
                                            State = EventState.OpenPause;
                                            result += counter.ToString();
                                            break;
                                        }
                                    }
                                case EventState.OpenPause:
                                    {
                                            State = EventState.Open;
                                            result += (++counter).ToString();
                                            break;
                                    }
                                case EventState.Close:
                                    {
                                        State = EventState.ClosePause;
                                        result += counter.ToString();
                                        break;
                                    }
                                case EventState.ClosePause:
                                    {
                                        State = EventState.Close;
                                        result += (--counter).ToString();
                                        break;
                                    }
                                default:
                                    throw new ArgumentException();
                            }
                            break;
                            }
                    case '.': {
                            switch (State)
                            {
                                case EventState.Nothing: {
                                        result += counter.ToString();
                                        break;
                                    }
                                case EventState.Open:{
                                        result += counter < 5 ?  (++counter).ToString() : counter.ToString();
                                        break;
                                    }
                                case EventState.OpenPause:{ 
                                        result += counter.ToString();
                                        break;
                                    }
                                case EventState.Close:{
                                        result += counter > 0 ? (--counter).ToString() : counter.ToString();
                                        break;
                                    }
                                case EventState.ClosePause:{
                                        result  += counter.ToString();
                                        break;
                                        }
                                default:
                                        throw new ArgumentException();
                            }
                            break;
                        }
                    case 'O': {
                                    switch (State)
                                    {
                                        case EventState.Open:
                                            result += (--counter).ToString();
                                            State = EventState.Close;
                                            break;
                                        case EventState.Close:
                                            result += (++counter).ToString();
                                            State = EventState.Open;
                                            break;
                                        default:
                                            throw new ArgumentException();
                                    }

                                    break;
                                }
                    default:
                            throw new ArgumentException();
                }
            }
            return result;
        }
    }
}
