// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/HandCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__HAND_COMMAND__STRUCT_HPP_
#define HALODI_MSGS__MSG__HAND_COMMAND__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__HandCommand __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__HandCommand __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct HandCommand_
{
  using Type = HandCommand_<ContainerAllocator>;

  explicit HandCommand_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->closure = 0.0;
      this->speed = 0.0;
      this->force = 0.0;
    }
  }

  explicit HandCommand_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->closure = 0.0;
      this->speed = 0.0;
      this->force = 0.0;
    }
  }

  // field types and members
  using _closure_type =
    double;
  _closure_type closure;
  using _speed_type =
    double;
  _speed_type speed;
  using _force_type =
    double;
  _force_type force;

  // setters for named parameter idiom
  Type & set__closure(
    const double & _arg)
  {
    this->closure = _arg;
    return *this;
  }
  Type & set__speed(
    const double & _arg)
  {
    this->speed = _arg;
    return *this;
  }
  Type & set__force(
    const double & _arg)
  {
    this->force = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::HandCommand_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::HandCommand_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::HandCommand_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::HandCommand_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__HandCommand
    std::shared_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__HandCommand
    std::shared_ptr<halodi_msgs::msg::HandCommand_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const HandCommand_ & other) const
  {
    if (this->closure != other.closure) {
      return false;
    }
    if (this->speed != other.speed) {
      return false;
    }
    if (this->force != other.force) {
      return false;
    }
    return true;
  }
  bool operator!=(const HandCommand_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct HandCommand_

// alias to use template instance with default allocator
using HandCommand =
  halodi_msgs::msg::HandCommand_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__HAND_COMMAND__STRUCT_HPP_
