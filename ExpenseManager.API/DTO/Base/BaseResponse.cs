using ExpenseManager.API.Models;

namespace ExpenseManager.API.DTO.Base
{
    /// <summary>
    /// Base Response class
    /// </summary>
    public class BaseResponse : BaseDto
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseResponse()
        {
            MessageInformation = new MessageInformation();
        }
        /// <summary>
        /// MessageInformation model
        /// </summary>
        public MessageInformation MessageInformation { get; set; }
    }
}
