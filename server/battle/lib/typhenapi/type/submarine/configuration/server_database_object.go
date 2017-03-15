// This file was generated by typhen-api

package configuration

import (
	"errors"
	"github.com/shiwano/submarine/server/battle/lib/typhenapi"
)

var _ = errors.New

// ServerDatabaseObject is a kind of TyphenAPI type.
type ServerDatabaseObject struct {
	Host     string `json:"host" msgpack:"host"`
	Port     int64  `json:"port" msgpack:"port"`
	User     string `json:"user" msgpack:"user"`
	Password string `json:"password" msgpack:"password"`
}

// Coerce the fields.
func (t *ServerDatabaseObject) Coerce() error {
	return nil
}

// Bytes creates the byte array.
func (t *ServerDatabaseObject) Bytes(serializer typhenapi.Serializer) ([]byte, error) {
	if err := t.Coerce(); err != nil {
		return nil, err
	}

	data, err := serializer.Serialize(t)
	if err != nil {
		return nil, err
	}

	return data, nil
}
