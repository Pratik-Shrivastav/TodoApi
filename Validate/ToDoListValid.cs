using FluentValidation;
using TodoApi.Dtos;

namespace TodoApi.Validate
{
    public class ToDoListValid : AbstractValidator<TodoItemDTO>
    {
        public ToDoListValid()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.").Length(1, 100).WithMessage("Name must be between 1 and 100 characters."); ;
            RuleFor(x => x.IsComplete).NotNull().WithMessage("Completion status must be specified.");
        }
    }

}
