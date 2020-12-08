// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/ContactPointCommand.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/contact_point_command__struct.hpp"
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

void ContactPointCommand_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::ContactPointCommand(_init);
}

void ContactPointCommand_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::ContactPointCommand *>(message_memory);
  typed_message->~ContactPointCommand();
}

size_t size_function__ContactPointCommand__normal(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ContactPointCommand__normal(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return &member[index];
}

void * get_function__ContactPointCommand__normal(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return &member[index];
}

void resize_function__ContactPointCommand__normal(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  member->resize(size);
}

size_t size_function__ContactPointCommand__coefficient_of_friction(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ContactPointCommand__coefficient_of_friction(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__ContactPointCommand__coefficient_of_friction(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__ContactPointCommand__coefficient_of_friction(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__ContactPointCommand__maximum_contact_force(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ContactPointCommand__maximum_contact_force(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__ContactPointCommand__maximum_contact_force(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__ContactPointCommand__maximum_contact_force(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__ContactPointCommand__rho_weight_divider(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ContactPointCommand__rho_weight_divider(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__ContactPointCommand__rho_weight_divider(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__ContactPointCommand__rho_weight_divider(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember ContactPointCommand_message_member_array[7] = {
  {
    "parent_joint",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointName>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, parent_joint),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "contact_point_id",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, contact_point_id),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "point_in_contact",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, point_in_contact),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "normal",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, normal),  // bytes offset in struct
    nullptr,  // default value
    size_function__ContactPointCommand__normal,  // size() function pointer
    get_const_function__ContactPointCommand__normal,  // get_const(index) function pointer
    get_function__ContactPointCommand__normal,  // get(index) function pointer
    resize_function__ContactPointCommand__normal  // resize(index) function pointer
  },
  {
    "coefficient_of_friction",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, coefficient_of_friction),  // bytes offset in struct
    nullptr,  // default value
    size_function__ContactPointCommand__coefficient_of_friction,  // size() function pointer
    get_const_function__ContactPointCommand__coefficient_of_friction,  // get_const(index) function pointer
    get_function__ContactPointCommand__coefficient_of_friction,  // get(index) function pointer
    resize_function__ContactPointCommand__coefficient_of_friction  // resize(index) function pointer
  },
  {
    "maximum_contact_force",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, maximum_contact_force),  // bytes offset in struct
    nullptr,  // default value
    size_function__ContactPointCommand__maximum_contact_force,  // size() function pointer
    get_const_function__ContactPointCommand__maximum_contact_force,  // get_const(index) function pointer
    get_function__ContactPointCommand__maximum_contact_force,  // get(index) function pointer
    resize_function__ContactPointCommand__maximum_contact_force  // resize(index) function pointer
  },
  {
    "rho_weight_divider",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ContactPointCommand, rho_weight_divider),  // bytes offset in struct
    nullptr,  // default value
    size_function__ContactPointCommand__rho_weight_divider,  // size() function pointer
    get_const_function__ContactPointCommand__rho_weight_divider,  // get_const(index) function pointer
    get_function__ContactPointCommand__rho_weight_divider,  // get(index) function pointer
    resize_function__ContactPointCommand__rho_weight_divider  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers ContactPointCommand_message_members = {
  "halodi_msgs::msg",  // message namespace
  "ContactPointCommand",  // message name
  7,  // number of fields
  sizeof(halodi_msgs::msg::ContactPointCommand),
  ContactPointCommand_message_member_array,  // message members
  ContactPointCommand_init_function,  // function to initialize message memory (memory has to be allocated)
  ContactPointCommand_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t ContactPointCommand_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &ContactPointCommand_message_members,
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
get_message_type_support_handle<halodi_msgs::msg::ContactPointCommand>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::ContactPointCommand_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, ContactPointCommand)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::ContactPointCommand_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
