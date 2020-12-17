// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/JointNullSpaceConfiguration.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/joint_null_space_configuration__struct.hpp"
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

void JointNullSpaceConfiguration_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::JointNullSpaceConfiguration(_init);
}

void JointNullSpaceConfiguration_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::JointNullSpaceConfiguration *>(message_memory);
  typed_message->~JointNullSpaceConfiguration();
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember JointNullSpaceConfiguration_message_member_array[2] = {
  {
    "joint",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointName>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointNullSpaceConfiguration, joint),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "q_nullspace",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointNullSpaceConfiguration, q_nullspace),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers JointNullSpaceConfiguration_message_members = {
  "halodi_msgs::msg",  // message namespace
  "JointNullSpaceConfiguration",  // message name
  2,  // number of fields
  sizeof(halodi_msgs::msg::JointNullSpaceConfiguration),
  JointNullSpaceConfiguration_message_member_array,  // message members
  JointNullSpaceConfiguration_init_function,  // function to initialize message memory (memory has to be allocated)
  JointNullSpaceConfiguration_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t JointNullSpaceConfiguration_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &JointNullSpaceConfiguration_message_members,
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
get_message_type_support_handle<halodi_msgs::msg::JointNullSpaceConfiguration>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::JointNullSpaceConfiguration_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, JointNullSpaceConfiguration)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::JointNullSpaceConfiguration_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
