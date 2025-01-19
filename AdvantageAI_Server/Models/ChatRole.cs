namespace AdvantageAIWeb.Models.Chat
{
    /// <summary>
    /// Enum representing the roles in a chat system.
    /// </summary>
    public enum ChatRole
    {
        /// <summary>
        /// The user sending a message.
        /// </summary>
        User = 0,

        /// <summary>
        /// The assistant responding to the user.
        /// </summary>
        Assistant = 1,

        /// <summary>
        /// System messages for internal processing or control.
        /// </summary>
        System = 2
    }
}
