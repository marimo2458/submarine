package resource

import (
	"path"
	"runtime"

	"github.com/shiwano/submarine/server/battle/server/config"
)

var cacheDir string
var clientAssetDir string

func init() {
	_, filename, _, _ := runtime.Caller(1)
	rootDir := path.Join(path.Dir(filename), "../../../../")
	cacheDir = path.Join(rootDir, "server/battle/.cache")

	switch config.Env {
	case "test":
		clientAssetDir = path.Join(rootDir, "server/battle/test_fixtures/assets")
	case "development":
		clientAssetDir = path.Join(rootDir, "server/battle/assets")
	default:
		clientAssetDir = path.Join(rootDir, "server/battle/assets")
	}
}
