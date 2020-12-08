// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/TaskSpaceCommand.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/task_space_command__struct.hpp"
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

void TaskSpaceCommand_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::TaskSpaceCommand(_init);
}

void TaskSpaceCommand_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::TaskSpaceCommand *>(message_memory);
  typed_message->~TaskSpaceCommand();
}

size_t size_function__TaskSpaceCommand__passivity_input(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::PassivityData> *>(untyped_member);
  return member->size();
}

const void * get_const_function__TaskSpaceCommand__passivity_input(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::PassivityData> *>(untyped_member);
  return &member[index];
}

void * get_function__TaskSpaceCommand__passivity_input(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::PassivityData> *>(untyped_member);
  return &member[index];
}

void resize_function__TaskSpaceCommand__passivity_input(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::PassivityData> *>(untyped_member);
  member->resize(size);
}

size_t size_function__TaskSpaceCommand__orientation_feedback_parameters(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  return member->size();
}

const void * get_const_function__TaskSpaceCommand__orientation_feedback_parameters(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  return &member[index];
}

void * get_function__TaskSpaceCommand__orientation_feedback_parameters(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  return &member[index];
}

void resize_function__TaskSpaceCommand__orientation_feedback_parameters(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  member->resize(size);
}

size_t size_function__TaskSpaceCommand__position_feedback_parameters(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  return member->size();
}

const void * get_const_function__TaskSpaceCommand__position_feedback_parameters(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  return &member[index];
}

void * get_function__TaskSpaceCommand__position_feedback_parameters(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  return &member[index];
}

void resize_function__TaskSpaceCommand__position_feedback_parameters(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::FeedbackParameters3D> *>(untyped_member);
  member->resize(size);
}

size_t size_function__TaskSpaceCommand__nullspace_command(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::JointNullSpaceConfiguration> *>(untyped_member);
  return member->size();
}

const void * get_const_function__TaskSpaceCommand__nullspace_command(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::JointNullSpaceConfiguration> *>(untyped_member);
  return &member[index];
}

void * get_function__TaskSpaceCommand__nullspace_command(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::JointNullSpaceConfiguration> *>(untyped_member);
  return &member[index];
}

void resize_function__TaskSpaceCommand__nullspace_command(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::JointNullSpaceConfiguration> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember TaskSpaceCommand_message_member_array[12] = {
  {
    "body_frame",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::ReferenceFrameName>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, body_frame),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "expressed_in_frame",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::ReferenceFrameName>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, expressed_in_frame),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "express_in_z_up",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, express_in_z_up),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "pose",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Pose>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, pose),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "angular_velocity",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, angular_velocity),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "linear_velocity",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, linear_velocity),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "angular_acceleration",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, angular_acceleration),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "linear_acceleration",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, linear_acceleration),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "passivity_input",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::PassivityData>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, passivity_input),  // bytes offset in struct
    nullptr,  // default value
    size_function__TaskSpaceCommand__passivity_input,  // size() function pointer
    get_const_function__TaskSpaceCommand__passivity_input,  // get_const(index) function pointer
    get_function__TaskSpaceCommand__passivity_input,  // get(index) function pointer
    resize_function__TaskSpaceCommand__passivity_input  // resize(index) function pointer
  },
  {
    "orientation_feedback_parameters",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::FeedbackParameters3D>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, orientation_feedback_parameters),  // bytes offset in struct
    nullptr,  // default value
    size_function__TaskSpaceCommand__orientation_feedback_parameters,  // size() function pointer
    get_const_function__TaskSpaceCommand__orientation_feedback_parameters,  // get_const(index) function pointer
    get_function__TaskSpaceCommand__orientation_feedback_parameters,  // get(index) function pointer
    resize_function__TaskSpaceCommand__orientation_feedback_parameters  // resize(index) function pointer
  },
  {
    "position_feedback_parameters",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::FeedbackParameters3D>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, position_feedback_parameters),  // bytes offset in struct
    nullptr,  // default value
    size_function__TaskSpaceCommand__position_feedback_parameters,  // size() function pointer
    get_const_function__TaskSpaceCommand__position_feedback_parameters,  // get_const(index) function pointer
    get_function__TaskSpaceCommand__position_feedback_parameters,  // get(index) function pointer
    resize_function__TaskSpaceCommand__position_feedback_parameters  // resize(index) function pointer
  },
  {
    "nullspace_command",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointNullSpaceConfiguration>(),  // members of sub message
    true,  // is array
    7,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::TaskSpaceCommand, nullspace_command),  // bytes offset in struct
    nullptr,  // default value
    size_function__TaskSpaceCommand__nullspace_command,  // size() function pointer
    get_const_function__TaskSpaceCommand__nullspace_command,  // get_const(index) function pointer
    get_function__TaskSpaceCommand__nullspace_command,  // get(index) function pointer
    resize_function__TaskSpaceCommand__nullspace_command  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers TaskSpaceCommand_message_members = {
  "halodi_msgs::msg",  // message namespace
  "TaskSpaceCommand",  // message name
  12,  // number of fields
  sizeof(halodi_msgs::msg::TaskSpaceCommand),
  TaskSpaceCommand_message_member_array,  // message members
  TaskSpaceCommand_init_function,  // function to initialize message memory (memory has to be allocated)
  TaskSpaceCommand_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t TaskSpaceCommand_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &TaskSpaceCommand_message_members,
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
get_message_type_support_handle<halodi_msgs::msg::TaskSpaceCommand>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::TaskSpaceCommand_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, TaskSpaceCommand)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::TaskSpaceCommand_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
