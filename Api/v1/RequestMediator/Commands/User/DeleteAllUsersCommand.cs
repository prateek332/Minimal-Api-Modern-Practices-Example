﻿using Api.v1.Models.UserModels;

namespace Api.v1.RequestsMediator.Commands.User;

public class DeleteAllUsersCommand: IRequest<List<UserResponseModel>>
{
}
