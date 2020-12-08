// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/WholeBodyControllerCommand.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/whole_body_controller_command__struct.hpp"
#include "rosidl_typesupport_introspection_cpp/field_types.hpp"
#include "rosidl_typesupport_introspection_cpp/identifier.hpp"
#include "rosidl_typesupport_introspection_cpp/message_introspection.hpp"
#include "rosidl_typesupport_introspection_cpp/message_type_support_decl.hpp"
#include "rosidl_typesupport_introspection_cpp/visibility_control.h"

namespace halodi_msgs
{

namespace msg
{

namespace rosidl_typesupport_introspection_cpp
{

void WholeBodyControllerCommand_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::WholeBodyControllerCommand(_init);
}

void WholeBodyControllerCommand_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::WholeBodyControllerCommand *>(message_memory);
  typed_message->~WholeBodyControllerCommand();
}

size_t size_function__WholeBodyControllerCommand__task_space_commands(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::TaskSpaceCommand> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyControllerCommand__task_space_commands(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::TaskSpaceCommand> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyControllerCommand__task_space_commands(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::TaskSpaceCommand> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyControllerCommand__task_space_commands(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::TaskSpaceCommand> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyControllerCommand__joint_space_commands(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::JointSpaceCommand> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyControllerCommand__joint_space_commands(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::JointSpaceCommand> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyControllerCommand__joint_space_commands(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::JointSpaceCommand> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyControllerCommand__joint_space_commands(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::JointSpaceCommand> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyControllerCommand__contact_point_commands(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::ContactPointCommand> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyControllerCommand__contact_point_commands(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::ContactPointCommand> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyControllerCommand__contact_point_commands(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::ContactPointCommand> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyControllerCommand__contact_point_commands(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::ContactPointCommand> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyControllerCommand__driving_command(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::DrivingCommand> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyControllerCommand__driving_command(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::DrivingCommand> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyControllerCommand__driving_command(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::DrivingCommand> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyControllerCommand__driving_command(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::DrivingCommand> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyControllerCommand__icp_command(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyControllerCommand__icp_command(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyControllerCommand__icp_command(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyControllerCommand__icp_command(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember WholeBodyControllerCommand_message_member_array[7] = {
  {
    "sequence_id",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, sequence_id),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "balance_mode",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::BalanceMode>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, balance_mode),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "task_space_commands",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::TaskSpaceCommand>(),  // members of sub message
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, task_space_commands),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyControllerCommand__task_space_commands,  // size() function pointer
    get_const_function__WholeBodyControllerCommand__task_space_commands,  // get_const(index) function pointer
    get_function__WholeBodyControllerCommand__task_space_commands,  // get(index) function pointer
    resize_function__WholeBodyControllerCommand__task_space_commands  // resize(index) function pointer
  },
  {
    "joint_space_commands",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointSpaceCommand>(),  // members of sub message
    true,  // is array
    25,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, joint_space_commands),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyControllerCommand__joint_space_commands,  // size() function pointer
    get_const_function__WholeBodyControllerCommand__joint_space_commands,  // get_const(index) function pointer
    get_function__WholeBodyControllerCommand__joint_space_commands,  // get(index) function pointer
    resize_function__WholeBodyControllerCommand__joint_space_commands  // resize(index) function pointer
  },
  {
    "contact_point_commands",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::ContactPointCommand>(),  // members of sub message
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, contact_point_commands),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyControllerCommand__contact_point_commands,  // size() function pointer
    get_const_function__WholeBodyControllerCommand__contact_point_commands,  // get_const(index) function pointer
    get_function__WholeBodyControllerCommand__contact_point_commands,  // get(index) function pointer
    resize_function__WholeBodyControllerCommand__contact_point_commands  // resize(index) function pointer
  },
  {
    "driving_command",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::DrivingCommand>(),  // members of sub message
    true,  // is array
    20,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, driving_command),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyControllerCommand__driving_command,  // size() function pointer
    get_const_function__WholeBodyControllerCommand__driving_command,  // get_const(index) function pointer
    get_function__WholeBodyControllerCommand__driving_command,  // get(index) function pointer
    resize_function__WholeBodyControllerCommand__driving_command  // resize(index) function pointer
  },
  {
    "icp_command",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    true,  // is array
    20,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyControllerCommand, icp_command),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyControllerCommand__icp_command,  // size() function pointer
    get_const_function__WholeBodyControllerCommand__icp_command,  // get_const(index) function pointer
    get_function__WholeBodyControllerCommand__icp_command,  // get(index) function pointer
    resize_function__WholeBodyControllerCommand__icp_command  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers WholeBodyControllerCommand_message_members = {
  "halodi_msgs::msg",  // message namespace
  "WholeBodyControllerCommand",  // message name
  7,  // number of fields
  sizeof(halodi_msgs::msg::WholeBodyControllerCommand),
  WholeBodyControllerCommand_message_member_array,  // message members
  WholeBodyControllerCommand_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyControllerCommand_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t WholeBodyControllerCommand_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &WholeBodyControllerCommand_message_members,
  get_message_typesupport_handle_function,
};

}  // namespace rosidl_typesupport_introspection_cpp

}  // namespace msg

}  // namespace halodi_msgs


namespace rosidl_typesupport_introspection_cpp
{

template<>
ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
get_message_type_support_handle<halodi_msgs::msg::WholeBodyControllerCommand>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::WholeBodyControllerCommand_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, WholeBodyControllerCommand)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::WholeBodyControllerCommand_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
